using NoteOne.Application.Interfaces;
using NoteOne.Domain;
using NoteOne.Persistence;

namespace NoteOne.Infrastructure.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(NoteOneDBContext context) : base(context)
        {
        }

        
    }
}
