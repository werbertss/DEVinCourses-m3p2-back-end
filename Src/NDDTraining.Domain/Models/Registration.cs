using NDDTraining.Domain.Models.Enums;
using System;
namespace NDDTraining.Domain.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainingId { get; set; }
        public Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual Training Training { get; set; }
        public List<Training> TrainingsSuspended { get; set; }
        public List<Training> TrainingsAvailable { get; set; }
        public List<Training> TrainingsFinished { get; set; }
        public List<Training> TrainingsProgress { get; set; }




        public Registration()
        {
        }

        public Registration(int id, int userId, int trainingId, Status status, User user )
        {
            Id = id;
            UserId = userId;
            TrainingId = trainingId;
            Status = status;
            User = user;
           
        }
    }
}

