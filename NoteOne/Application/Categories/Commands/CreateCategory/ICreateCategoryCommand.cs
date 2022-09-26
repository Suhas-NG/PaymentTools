

using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreateCategory
{
    public interface ICreateCategoryCommand
    {
        Category? Execute(CreateCategoryModel model);
    }
}
