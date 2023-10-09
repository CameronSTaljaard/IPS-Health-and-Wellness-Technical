using IPS_Health_and_Management_API.Context;
using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Repositories.Interfaces;

namespace IPS_Health_and_Management_API.Repositories.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue = false;
        private DataContext _context;

        public Dictionary<Type, object> _repositories = new();

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public GenericRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity
        {
            if (!_repositories.ContainsKey(typeof(TEntity)))
            {
                _repositories[typeof(TEntity)] = Init<TEntity, GenericRepository<TEntity>>();
            }
            return (GenericRepository<TEntity>) _repositories[typeof(TEntity)];
        }

        RepoEntity Init<TEntity, RepoEntity>()
                where TEntity : Entity
                where RepoEntity : GenericRepository<TEntity>, new()
        {
            RepoEntity repo = new RepoEntity();
            repo.Init(_context);

            return repo;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void Save() => _context.SaveChanges();


    }
}
