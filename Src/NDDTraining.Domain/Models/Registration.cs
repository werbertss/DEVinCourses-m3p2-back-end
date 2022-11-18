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
        
        public virtual IList<CompletedModule> CompletedModules { get; set; }


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

