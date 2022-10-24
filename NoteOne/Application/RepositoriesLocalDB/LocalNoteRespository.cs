

using NoteOne.Application.Interfaces;
using NoteOne.Domain;

namespace NoteOne.Application.RepositoriesLocalDB
{
    public class LocalNoteRespository : INoteRepository
    {
        private LocalDbContext _context;
        public LocalNoteRespository()
        {
            _context = new LocalDbContext();
        }
        public Note? Add(Note entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Note entity)
        {
            throw new NotImplementedException();
        }

        public Note? Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Note Update(Note entity)
        {
            throw new NotImplementedException();
        }
    }
}
