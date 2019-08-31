using System.Collections.Generic;
using DDD.Application.DTO.Right;

namespace DDD.Application.DTO.User
{
    public class LoginOutput
    {
        public LoginOutput()
        {
            UserRightList=new List<RightDto>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int StatusId { get; set; }

        public List<RightDto> UserRightList;
    }
}