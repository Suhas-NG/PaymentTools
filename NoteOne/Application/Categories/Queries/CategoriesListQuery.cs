using NoteOne.Application.Interfaces;
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Queries
{
    internal class CategoriesListQuery : ICategoriesListQuery
    {
        private ICategoryRepository _categoryRepository;
        public CategoriesListQuery(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public List<Category> Execute()
        {
            return new List<Category>();   
        }
    }
}
