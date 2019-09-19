using Domain.Repository;
using Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly HelpIncContext HelpIncContext;

        public BaseRepository(HelpIncContext helpIncContext)
        {
            HelpIncContext = helpIncContext;
        }

        public void Incluid(TEntity entity)
        {
            HelpIncContext.Set<TEntity>().Add(entity);
            HelpIncContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            HelpIncContext.Set<TEntity>().Update(entity);
            HelpIncContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            HelpIncContext.Remove(entity);
            HelpIncContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return HelpIncContext.Set<TEntity>().ToList();
        }

        public TEntity GetbyId(long Id)
        {
            return HelpIncContext.Set<TEntity>().Find(Id);
        }

        public void SaveChanges()
        {
            HelpIncContext.SaveChanges();
        }

        public void Dispose()
        {
            HelpIncContext.Dispose();
        }
    }
}