using NoteOne.Domain;

namespace NoteOne.Application.Categories.Queries
{
    public interface IGetUserCategoriesQuery
    {
        User Execute(Guid guid);
    }
}
