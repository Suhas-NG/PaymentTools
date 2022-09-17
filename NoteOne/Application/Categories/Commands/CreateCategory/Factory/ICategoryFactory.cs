using NoteOne.Domain;


namespace NoteOne.Application.Categories.Commands.CreateCategory.Factory
{
    public interface ICategoryFactory
    {
        Category? Create(DateTime date, User user, string categoryName);
    }
}
