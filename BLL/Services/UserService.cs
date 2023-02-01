using DAL.Model.Response;
using DAL.Repository;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        public UsersResponse GetUserById(int userId)
        {
           return _repo.GetUserById(userId);
        }
    }
}
