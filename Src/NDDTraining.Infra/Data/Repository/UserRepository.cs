using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Models;
using NDDTraining.Infra.Data.Context;

namespace NDDTraining.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(NDDTrainingDbContext context) : base(context) { }

        public bool VerifyLogin(Login login)
        {
            return _context.Users.Any(u => u.Email == login.Email && u.Password == login.Password);
        }
    }
}
