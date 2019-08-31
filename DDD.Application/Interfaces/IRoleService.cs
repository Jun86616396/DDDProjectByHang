using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.Role;

namespace DDD.Application.Interfaces
{
    public interface IRoleService
    {
        bool AddRole(RoleDto roleDto);

        bool UpdateRole(RoleDto roleDto);


        Task<BindingList<RoleDto>> GetRoleList();

        bool DeleteRole(int roleId);

        List<RightDto> GetRightListByRoleId(int roleId);

        bool GiveRoleRights(int roleId, List<int> rightIdList);
    }
}