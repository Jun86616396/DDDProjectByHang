using System.Collections.Generic;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.User;
using Infra.Utility.Result;

namespace DDD.Application.Interfaces
{
    public interface IUserService
    {
        LoginOutput UserLogin(UserDto user);


        void UserRegister(UserRegisterDto registerDto);

        PagedResult<UserDto> GetUserList(int pageIndex, int pageSize);

        List<UserDto> GetUserList();

        bool AddUser(UserDto userDto);

        bool UpdateUserState(UserDto userDto);


        bool UpdateUser(UserEditDto userEditDto);

        bool DeleteUser(UserDto userDto);

        bool GiveUserRoles(int userId, List<int> roleIdList);

        List<RightDto> GetUserRights(int userId);

    }
}