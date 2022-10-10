using NoteOne.Domain;

namespace NoteOne.Application.Interfaces
{
    public interface INoteRepository
    {
        Note Update(Note entity);
        Note? Add(Note entity);
        bool Delete(Note entity);
        Note? Get(Guid id);
        bool Save();
    }
}
