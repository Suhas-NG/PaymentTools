using Microsoft.EntityFrameworkCore;
using NoteOne.Application.Interfaces;
using NoteOne.Domain;
using NoteOne.Persistence;
using System.Linq.Expressions;

namespace NoteOne.Infrastructure.Repositories
{
    public class PageRepository : GenericRepository<Page>, IPageRepository
    {
        public PageRepository(NoteOneDBContext context) : base(context)
        {
        }

        public override IEnumerable<Page> Find(Expression<Func<Page, bool>> predicate)
        {
            return context.Pages
                .Include(o => o.Notes)
                .Where(predicate)
                .ToList();
        }
    }
}
