
namespace NDDTraining.Domain.Models
{
    public class User
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string CPF { get; set; }
        public string Image { get; set; }

        public User()
        {

        }
        
    }
    
}