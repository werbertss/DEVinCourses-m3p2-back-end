namespace NDDTraining.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity: class
    {
        IList<TEntity>GetAll();
        TEntity GetById(Tkey id);
        void Insert (TEntity entity);
        void Change (TEntity entity);
        void Delete (TEntity entity);
        void Update(TEntity entity);
    }
}