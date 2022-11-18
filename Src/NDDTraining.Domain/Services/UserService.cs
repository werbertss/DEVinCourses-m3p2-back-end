using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Exceptions;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetByToken(string id)
        {
            return _userRepository.GetByToken(id);
        }
        public string VerifyLogin(LoginDTO loginDTO)
        {
            bool isAllowed = _userRepository.VerifyLogin(new Login(loginDTO));

            if (isAllowed)
                return "JWT TOKEN";
                // TODO Call TokenService

            throw new InvalidLoginException("Email ou senha não encontrados");
        }
    }
}
