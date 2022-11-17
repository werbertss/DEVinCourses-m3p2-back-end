using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User GetByToken(string id);
    }
}
