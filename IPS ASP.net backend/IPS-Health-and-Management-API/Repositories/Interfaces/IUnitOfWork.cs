using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Repositories.Concrete;

namespace IPS_Health_and_Management_API.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public GenericRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity;
        void Dispose();
        void Save();
    }
}
