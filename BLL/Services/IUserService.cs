using DAL.Model.Response;

namespace BLL.Services
{
   public interface IUserService
    {
        public UsersResponse GetUserById(int userId);
    }
}
