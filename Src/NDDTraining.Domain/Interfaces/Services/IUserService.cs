using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User GetByToken(string id);
        void InsertUser(UserDTO newUser);
        String VerifyLogin (LoginDTO loginDTO);
        string Reset(string email);
    }
}
