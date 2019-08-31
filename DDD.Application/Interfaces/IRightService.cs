using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using DDD.Application.DTO.Right;

namespace DDD.Application.Interfaces
{
    public interface IRightService
    {
        Task<List<RightDto>> GetRightList();

    }
}