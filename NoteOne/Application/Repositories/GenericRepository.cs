using NoteOne.Persistence;
using System.Linq.Expressions;


namespace NoteOne.Infrastructure.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected NoteOneDBContext context;

        public GenericRepository(NoteOneDBContext context)
        {
            this.context = context;
        }
        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual bool SaveChanges()
        {
            int result = context.SaveChanges();
            return result > 0;
        }

        public virtual T Update(T entity)
        {
            return context.Update<T>(entity).Entity;
        }
    }
}
