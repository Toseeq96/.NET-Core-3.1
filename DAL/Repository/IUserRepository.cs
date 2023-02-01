using DAL.Model.Response;

namespace DAL.Repository
{
   public interface IUserRepository
    {
        public UsersResponse GetUserById(int userId);
    }
}
