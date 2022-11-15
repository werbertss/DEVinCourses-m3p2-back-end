using System;
namespace NDDTraining.Domain.DTOS
{
    public class RegistrarionDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }


        public RegistrarionDTO()
        {
        }
    }
}