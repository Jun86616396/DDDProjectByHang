using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.User;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.Bus;
using DDD.Domain.Commands.User;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediatorHandler _bus;
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRoleRightRepository _roleRightRepository;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, 
            IMediatorHandler bus,
            IUserRepository userRepository, 
            IUserRoleRepository userRoleRepository, 
            IRoleRightRepository roleRightRepository, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _bus = bus;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleRightRepository = roleRightRepository;
            _mapper = mapper;
        }

        public bool AddUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.CreateTime = DateTime.Now;

            _userRepository.Insert(user);

            return _unitOfWork.SaveChanges();
        }

        public bool DeleteUser(UserDto userDto)
        {
            _userRepository.Delete(userDto.UserId);

            return _unitOfWork.SaveChanges();
        }

        public PagedResult<UserDto> GetUserList(int pageIndex, int pageSize)
        {
            var bindingList = new BindingList<UserDto>();


            var query = _userRepository.GetAll().OrderByDescending(o => o.CreateTime)
                .ProjectTo<UserDto>(_mapper.ConfigurationProvider);

            var list = query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();

            ////获得记录总数
            var count = query.Count();


            list.ForEach(o => bindingList.Add(o));
            return new PagedResult<UserDto>(pageIndex, pageSize, count, bindingList);
        }

        public List<UserDto> GetUserList()
        {
            return _userRepository.GetAll().OrderByDescending(o => o.CreateTime)
                 .ProjectTo<UserDto>(_mapper.ConfigurationProvider).ToList();
        }

        public bool UpdateUser(UserEditDto userEditDto)
        {
            var user = _mapper.Map<User>(userEditDto);

            _userRepository.Update(user);

            return _unitOfWork.SaveChanges();
        }

        public bool UpdateUserState(UserDto userDto)
        {
            var user = _userRepository.GetById(userDto.UserId);

            user.StatusId = userDto.StatusId == 1 ? 0 : 1;

            _userRepository.Update(user);

            return _unitOfWork.SaveChanges();
        }

        public LoginOutput UserLogin(UserDto userDto)
        {

            var objUser = _userRepository.UserLogin(_mapper.Map<User>(userDto));

            var loginOutPut = _mapper.Map<LoginOutput>(objUser);
            loginOutPut.UserRightList = GetUserRights(loginOutPut.UserId);
            return loginOutPut;
        }


        public List<RightDto> GetUserRights(int userId)
        {

            var userRoleIds = _userRoleRepository.GetAll(userRoleRelation => userRoleRelation.UserId == userId)
                     .Select(z => z.RoleId).ToList();

            return _roleRightRepository.GetAllIncluding(o => userRoleIds.Contains(o.RoleId)).Select(t => t.Right).Distinct()
                   .ProjectTo<RightDto>(_mapper.ConfigurationProvider).ToList();

        }

        public bool GiveUserRoles(int userId, List<int> roleIdList)
        {


            var list = _userRoleRepository.GetAll(o => o.UserId == userId).ToList();
            foreach (var userRole in list)
            {
                _userRoleRepository.Delete(userRole);
            }

            foreach (var roleId in roleIdList)
            {
                _userRoleRepository.Insert(new UserRoleRelation() { RoleId = roleId, UserId = userId });
            }
            return _unitOfWork.SaveChanges();
        }

        public void UserRegister(UserRegisterDto registerDto)
        {
            var registerCommand = _mapper.Map<RegisterUserCommand>(registerDto);

            _bus.SendCommand(registerCommand);
        }


       
    }
}