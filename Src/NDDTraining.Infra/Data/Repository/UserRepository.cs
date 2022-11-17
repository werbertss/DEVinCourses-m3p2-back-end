using NDDTraining.Domain.Models;
using NDDTraining.Infra.Data.Context;

namespace NDDTraining.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User, int>
    {
        public UserRepository(NDDTrainingDbContext context) : base(context) { }
    }
}
