using System.Linq.Expressions;

namespace backgourmandys.Repositories
{
    public interface IRepository<TEntity> 
    {
        // Task<int> Add(TEntity contact);

        Task<TEntity?> GetById(int id);
        Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);

        // Task<bool> Update(TEntity contact);
        
        // Task<bool> Delete(int id);
    }
}
