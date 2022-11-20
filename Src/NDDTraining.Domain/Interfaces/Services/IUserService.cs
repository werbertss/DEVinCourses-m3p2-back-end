using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User GetByEmail(string token);
        void InsertUser(UserDTO newUser);
        void Update(UserDTO changedUser, int id);
        String VerifyLogin (LoginDTO loginDTO);
        string Reset(string email);
        string VerifyToken(string token, string password);
    }
}
