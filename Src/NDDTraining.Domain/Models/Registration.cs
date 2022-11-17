using NDDTraining.Domain.DTOS;
using System;
namespace NDDTraining.Domain.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainingId { get; set; }
        public string Status { get; set; }
        public virtual User User { get; set; }
        public virtual Training Training { get; set; }
        public virtual List<RegistrationDTO> TrainingsSuspended { get; set; }
        public virtual List<RegistrationDTO> TrainingsAvailable { get; set; }
        public virtual List<RegistrationDTO> TrainingsFinished { get; set; }
        public virtual List<RegistrationDTO> TrainingsProgress { get; set; }



        public Registration()
        {
        }

        public Registration(RegistrationDTO registration )
        {
            Id = registration.Id;
            UserId = registration.UserId;
            TrainingId = registration.TrainingId;
            Status = registration.Status;
            
           
        }
    }
}

