using Core.Entities;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public IResult Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
               var addedEntity= context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            return new SuccessResult();
        }

        public IResult Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
			return new SuccessResult();
		}

        public IDataResult<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return new SuccessDataResult<TEntity>(context.Set<TEntity>().SingleOrDefault(filter));
			}            
        }

        public IDataResult<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? new SuccessDataResult<List<TEntity>>(context.Set<TEntity>().ToList()) : new SuccessDataResult<List<TEntity>>(context.Set<TEntity>().Where(filter).ToList());
            }
        }

        public IResult Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
			return new SuccessResult();
		}
    }
}
