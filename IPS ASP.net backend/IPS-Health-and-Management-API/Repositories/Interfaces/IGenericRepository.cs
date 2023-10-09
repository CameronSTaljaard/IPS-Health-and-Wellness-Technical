using IPS_Health_and_Management_API.Models.Database;
using System.Linq.Expressions;

namespace IPS_Health_and_Management_API.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", bool getOnlyActive = true);
        TEntity GetByID(int id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
