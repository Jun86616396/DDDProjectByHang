using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.Role;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Domain.Repository;

namespace DDD.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleRightRepository _roleRightRepository;
        private readonly IMapper _mapper;


        public RoleService(IUnitOfWork unitOfWork ,IRoleRepository roleRepository,IRoleRightRepository roleRightRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _roleRepository = roleRepository;
            _roleRightRepository = roleRightRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        public bool AddRole(RoleDto roleDto)
        {
            var role = _mapper.Map<Role>(roleDto);
            role.CreateTime=DateTime.Now;

            _roleRepository.Insert(role);
            return _unitOfWork.SaveChanges();
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public bool DeleteRole(int roleId)
        {
            _roleRepository.Delete(roleId);
            return _unitOfWork.SaveChanges();
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <returns></returns>
        public async Task<BindingList<RoleDto>>   GetRoleList()
        {
            var bindingList = new BindingList<RoleDto>();

            var list = await _roleRepository.GetAll().ProjectTo<RoleDto>(_mapper.ConfigurationProvider).ToListAsync();

            list.ForEach(o => bindingList.Add(o));

            return bindingList;
        }

        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        public bool UpdateRole(RoleDto roleDto)
        {
          var role=  _roleRepository.GetById(roleDto.RoleId);

          role.RoleDesc = roleDto.RoleDesc;
          role.RoleName = roleDto.RoleName;

            _roleRepository.Update(role);
            return _unitOfWork.SaveChanges();
        }

        /// <summary>
        /// 获取角色Id的权限集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<RightDto> GetRightListByRoleId(int roleId)
        {
            return _roleRightRepository.GetAllIncluding(relation => relation.RoleId == roleId, o => o.Right)
                .Select(z => z.Right)
                .ProjectTo<RightDto>(_mapper.ConfigurationProvider)
                .ToList();
        }

        //删除角色Id所有的权限
        private void DelRoleIdRights(int roleId)
        {

            var roleRightList=  _roleRightRepository.GetAll(relation => relation.RoleId == roleId);

            foreach (var item in roleRightList)
            {
                _roleRightRepository.Delete(item);
            }
        }


        //给角色分配权限

        public bool GiveRoleRights(int roleId, List<int> rightIdList)
        {
            DelRoleIdRights(roleId);

            var roleRights = rightIdList.Select(rightId => new RoleRightRelation() { RoleId = roleId, RightId = rightId });

            foreach (var relation in roleRights)
            {
                _roleRightRepository.Insert(relation);
            }
            
            return _unitOfWork.SaveChanges();
        }

    }
}