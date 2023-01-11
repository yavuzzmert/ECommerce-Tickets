using System.Linq.Expressions;


namespace Core
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);

        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
