using NoteOne.Domain;

namespace NoteOne.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Category Update(Category entity);
        Category? Add(Category entity);
        bool Delete(Category entity);
        Category? Get(Guid id);   
        bool Save();
    }
}
