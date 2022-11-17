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
    }
}
