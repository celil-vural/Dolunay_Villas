using Entity.Contracts;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using System.Linq.Expressions;

namespace Repository.Concrete
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly RepositoryContext _context;

        protected RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity, bool trackChanges = false)
        {
            _context.Set<TEntity>().Add(entity);
            SaveChanges();
        }

        public void Delete(TEntity entity, bool trackChanges = false)
        {
            _context.Set<TEntity>().Remove(entity);
            SaveChanges();
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter, bool trackChanges = false)
        {
            return trackChanges
            ? _context.Set<TEntity>().Where(filter).SingleOrDefault()
            : _context.Set<TEntity>().AsNoTracking().Where(filter).SingleOrDefault();
        }


        public IEnumerable<TEntity>? GetList(bool trackChanges = false)
        {
            return trackChanges
                ? _context.Set<TEntity>()
                : _context.Set<TEntity>().AsNoTracking();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
