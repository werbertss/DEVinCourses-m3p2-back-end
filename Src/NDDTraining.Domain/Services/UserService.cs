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
        private readonly IEmailService _emailService;
        public UserService(IUserRepository userRepository,  IEmailService emailService )
        {
            _userRepository = userRepository;
            _emailService = emailService;
        }
        public User GetByEmail(string token)
        {
            var email = new JwtSecurityToken(jwtEncodedString: token);
            return _userRepository.GetByEmail(email.Claims.First(c => c.Type == "Email").Value);
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
        
        public string Reset(string emailReset)
        {
            var user = _userRepository.CheckResetEmail(emailReset);
            var resetToken = GeneratedToken(user.Id);

            user.ResetToken = resetToken;

           // _userRepository.Update(user);

            var email = new Email() { 
                To = emailReset,
                Subject = "Reset de Email",
                type = Domain.Enums.EmailType.ResetPassword,
                Parameters = new Dictionary<string, string> { { "Link", $"emailReset/{resetToken} " } }
            };

             _emailService.BuildAndSendMail(email);
            
            return checkedEmail;
        }
        public string GeneratedToken( int userId)
        {
            var data = $"{DateTime.Now.AddHours(1)}+{userId}+{Guid.NewGuid()}";
            return Convert.ToBase64String(data);
            
        }
    }
}
