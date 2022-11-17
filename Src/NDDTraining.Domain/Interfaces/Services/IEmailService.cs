
using NDDTraining.Domain.DTOS;

namespace NDDTraining.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        void SendEmail(string from, string recepient, string subject, string body);
    }
}