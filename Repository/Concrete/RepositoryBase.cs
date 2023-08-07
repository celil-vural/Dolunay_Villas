using Entity.Contracts;
using Entity.RequestParameters;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using Repository.Extensions;
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

        public virtual void Add(TEntity entity, bool trackChanges = false)
        {
            _context.Set<TEntity>().Add(entity);
            SaveChanges();
        }

        public virtual void Delete(TEntity entity, bool trackChanges = false)
        {
            _context.Set<TEntity>().Remove(entity);
            SaveChanges();
        }

        public virtual TEntity? Get(Expression<Func<TEntity, bool>> filter, bool trackChanges = false)
        {
            return trackChanges
            ? _context.Set<TEntity>().Where(filter).SingleOrDefault()
            : _context.Set<TEntity>().AsNoTracking().Where(filter).SingleOrDefault();
        }


        public virtual IEnumerable<TEntity>? GetList(bool trackChanges = false)
        {
            return trackChanges
                ? _context.Set<TEntity>()
                : _context.Set<TEntity>().AsNoTracking();
        }

        public virtual TEntity? GetWithId(int id, bool trackChanges = false)
        {
            return Get((r) => r.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        IEnumerable<TEntity>? IRepositoryBase<TEntity>.GetWithDetail(PageRequestParameters? parameters)
        {
            if (parameters == null)
            {
                return GetList();
            }
            return GetList()?.ToList().ToPaginatedList(parameters.PageNumber, parameters.PageSize);
        }
    }
}
