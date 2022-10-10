using NoteOne.Application.Interfaces;
using NoteOne.Domain;
using NoteOne.Persistence;

namespace NoteOne.Infrastructure.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository() : base(new NoteOneDBContext())
        {
        }

        public bool Delete(Note entity)
        {
            context.Notes.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public override Note Add(Note entity)
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
