using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreateCategory.Factory
{
    public class CategoryFactory : ICategoryFactory
    {
        public Category? Create(DateTime date, User? user, string categoryName)
        {
            Category? category = null; 
            if (user == null)
            {
                return category;
            }

            category = new Category()
            {
                UserGuid = user.Guid,
                Created = date,
                CategoryName = categoryName,
                Guid = Guid.NewGuid()
            };
            return category;
        }
    }
}
