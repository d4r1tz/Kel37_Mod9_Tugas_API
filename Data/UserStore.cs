using WebApplication1.Models.Dto;

namespace WebApplication1.Data
{
    public static class UserStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
        {
             new UserDTO{Id=1, Username="d4r1tz", Password="12345678"},
             new UserDTO{Id=2, Username="qwerty", Password="12345678"}
        };

    }
}
