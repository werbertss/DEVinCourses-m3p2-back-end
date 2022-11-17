using NDDTraining.Domain.Models;
using NDDTraining.Infra.Data.Context;

namespace NDDTraining.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User, int>
    {
        public UserRepository(NDDTrainingDbContext context) : base(context) { }

        public User CheckUserByEmail (string email)
        {
            var checkedUser = _context.Users.FirstOrDefault(u => u.Email == email);
            return(checkedUser);
        }

        public User CheckUserByCPF (string cpf)
        {
            var checkedUser = _context.Users.FirstOrDefault(c => c.CPF == cpf);
            return(checkedUser);
        }
    }
}
