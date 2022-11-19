using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Exceptions;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NDDTraining.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetByToken(string token)
        {
            var email = new JwtSecurityToken(jwtEncodedString: token);
            return _userRepository.GetByToken(email.Claims.First(c => c.Type == "Email").Value);
        }
        public string VerifyLogin(LoginDTO loginDTO)
        {
            if (loginDTO.Email == null || loginDTO.Password == null)
                throw new NoDataException("Email ou senha não preenchidos");

            bool isAllowed = _userRepository.VerifyLogin(new Login(loginDTO));

            if (isAllowed == false)
                throw new NotFoundException("Email ou senha não encontrados");

            // TODO Call TokenService
            return "JWT TOKEN";
        }

        public void InsertUser(UserDTO newUser)
        {
            var checkedEmail = _userRepository.CheckUserByEmail(newUser.Email);
            var checkedCPF = _userRepository.CheckUserByCPF(newUser.CPF);
            
            if (checkedEmail != null)
            {
                throw new DuplicateException("This user already exists !");
            }

            if (checkedCPF != null)
            {
                throw new DuplicateException("This user already exists !");
            }

            var recordUser = new User(newUser);     
           
            _userRepository.Insert(recordUser);
        }       
    }
}
