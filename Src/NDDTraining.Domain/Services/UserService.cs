using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepositorie;
        public UserService(IUserRepository userRepositorie)
        {
            _userRepositorie = userRepositorie;
        }
        public User GetByToken(string id)
        {
            return _userRepositorie.GetByToken(id);
        }

        public void InsertUser(User newUser)
        {
            var checkedEmail = _userRepositorie.CheckUserByEmail(newUser.Email);
            var checkedCPF = _userRepositorie.CheckUserByCPF(newUser.CPF);
            
            if (checkedEmail != null)
            {
                throw new Exception("This user already exists !");
            }

            if (checkedCPF != null)
            {
                throw new Exception("This user already exists !");
            }

            _userRepositorie.Insert(newUser);
        }

    }
}
