
namespace NoteOne.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryModel
    {
        public string categoryName { get; set; } = string.Empty;
        public Guid userId { get; set; }
    }
}
