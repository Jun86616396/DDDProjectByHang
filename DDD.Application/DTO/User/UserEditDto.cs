namespace DDD.Application.DTO.User
{
    public class UserEditDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public int StatusId { get; set; }

        public System.DateTime CreateTime { get; set; }
    }
}