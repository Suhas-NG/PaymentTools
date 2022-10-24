

using NoteOne.Application.Interfaces;
using NoteOne.Domain;

namespace NoteOne.Application.RepositoriesLocalDB
{
    public class LocalPageRespository : IPageRepository
    {
        private LocalDbContext _context;

        public LocalPageRespository(LocalDbContext localDbContext)
        {
            _context = localDbContext;  
        }

        public Page? Add(Page entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Page entity)
        {
            throw new NotImplementedException();
        }

        public Page? Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Page Update(Page entity)
        {
            throw new NotImplementedException();
        }
    }
}
