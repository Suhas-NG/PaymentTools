using NoteOne.Domain;

namespace NoteOne.Application.Categories.Queries
{
    public interface ICategoriesListQuery
    {
        public List<Category> Execute();
    }
}
