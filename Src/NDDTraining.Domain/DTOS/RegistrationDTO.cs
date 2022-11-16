using System;
using NDDTraining.Domain.Models;
using NDDTraining.Domain.Models.Enums;

namespace NDDTraining.Domain.DTOS
{
    public class RegistrationDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainingId { get; set; }
        public Status Status { get; set; }


        public RegistrationDTO()
        {
        }

        public RegistrationDTO (Registration registration)
        {
            Status = registration.Status;
        }
    }
}

