using Microsoft.EntityFrameworkCore;
using NoteOne.Application.Interfaces;
using NoteOne.Domain;
using NoteOne.Persistence;
using System.Linq.Expressions;

namespace NoteOne.Infrastructure.Repositories
{
    public class PageRepository : GenericRepository<Page>, IPageRepository
    {
        public PageRepository() : base(new NoteOneDBContext())
        {

        }

        public bool Delete(Page entity)
        {
            var result = context.Pages.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public override IEnumerable<Page> Find(Expression<Func<Page, bool>> predicate)
        {
            return context.Pages
                .Include(o => o.Notes)
                .Where(predicate)
                .ToList();
        }

        public override Page Add(Page entity)
        {
            return base.Add(entity);
        }
        public bool Save()
        {
            int save = context.SaveChanges();
            return save > 0;
        }
    }
}
