using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Exceptions;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;
using NDDTraining.Domain.Services.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

            User user = _userRepository.VerifyLogin(new Login(loginDTO));

            if (user == null)
                throw new NotFoundException("Email ou senha não encontrados");

            var token = TokenService.GenerateToken(user);

            return token;
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

        public void Update(UserDTO changedUser, int id)
        {
            var user = _userRepository.GetById(id);

            if(user == null)
                throw new NotFoundException("Usuario não localizado.");

            if(changedUser.Password != null)
            {
                user.Password = changedUser.Password;
            }
            if(changedUser.Image != null)
            {
                user.Image = changedUser.Image;
            }

            user.Name = changedUser.Name;
            user.Age = changedUser.Age;
            _userRepository.Update(user);
        }
        
        public string Reset(string emailReset)
        {
          //  throw new NotImplementedException();
            var user = _userRepository.CheckResetEmail(emailReset);
            var resetToken = GeneratedToken(user.Id);

            user.ResetToken = resetToken;

            _userRepository.Update(user);

            var email = new Email() { 
                To = emailReset,
                Subject = "Reset de Email",
                type = Domain.Enums.EmailType.ResetPassword,
                Parameters = new Dictionary<string, string> { { "Link", "http://localhost:4200/cadastro" }, { "Name", $"{user.Name} " } }
            };

             _emailService.BuildAndSendMail(email);

            var tokem = DecifraToken(resetToken);

            return tokem;
        }
        
        public string GeneratedToken( int userId)
        {
            var data = $"{DateTime.Now.AddHours(1)}+{userId}+{Guid.NewGuid()}";
            byte[] textoAsBytes = Encoding.ASCII.GetBytes(data);
            string resultado = System.Convert.ToBase64String(textoAsBytes);
            return resultado;
        }

        public string DecifraToken(string token)
        {
            byte[] res = System.Convert.FromBase64String(token);
            string resultado = Encoding.ASCII.GetString(res);
            string[] splittedValues = resultado.Split('+');
            string[] splittedLast = splittedValues[1].Split('+');
            string result = splittedLast[0];

            var id = Convert.ToInt32(result);

            var usuario = _userRepository.GetById(id);

            return usuario.ResetToken;
        }

    }
}
