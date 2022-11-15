using System;
namespace NDDTraining.Domain.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }

        public Registration()
        {
        }
    }

}

