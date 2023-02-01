using DAL.Context;
using System.Linq;
using DAL.Model.Response;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _db;
        public UserRepository(MyContext db)
        {
            _db = db;
        }
        public UsersResponse GetUserById(int userId)
        {
            var result = (
                           from u in _db.Users
                           where u.UserId == userId
                           select new UsersResponse
                           {
                               Id = u.UserId,
                               FirstName = u.FirstName,
                               LastName = u.LastName
                           }
                          ).FirstOrDefault();

            return result;
        }
    }
}
