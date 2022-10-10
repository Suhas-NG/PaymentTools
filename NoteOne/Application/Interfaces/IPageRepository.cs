
using NoteOne.Domain;

namespace NoteOne.Application.Interfaces
{
    public interface IPageRepository
    {
        Page Update(Page entity);
        Page? Add(Page entity);
        bool Delete(Page entity);
        Page? Get(Guid id);
        bool Save();
    }
}
