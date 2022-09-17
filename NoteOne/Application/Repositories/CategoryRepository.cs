using Microsoft.EntityFrameworkCore;
using NoteOne.Application.Interfaces;
using NoteOne.Domain;
using NoteOne.Persistence;

namespace NoteOne.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category> , ICategoryRepository
    {
        public CategoryRepository(NoteOneDBContext context) : base(context)
        {

        }

        public bool Create(Category entity)
        {
            context.Add(entity);
            return true;
        }

        public bool Delete(Category entity)
        {
            var result =  context.Categories.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public Category Get(Guid id)
        {
            Category? category = context.Categories?
                .Include(c => c.Pages)
                .Where(c => c.Guid == id).First();
                
            if (category != null && category.Pages != null)
            {
                return category; 
            } else
            {
                throw new Exception();
            }
        }

        public bool Save()
        {
           int save = context.SaveChanges();
           return save > 0;
        }

        public override Category Update(Category entity)
        {
            var category = context.Categories
                .Single( c => c.Guid == entity.Guid);

            if (category != null)
            {
                category.CategoryName = entity.CategoryName;
            }
            return base.Update(category);
        }

        bool ICategoryRepository.Add(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
