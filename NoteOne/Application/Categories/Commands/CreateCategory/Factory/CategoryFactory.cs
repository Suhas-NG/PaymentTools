using NoteOne.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                CategoryName = categoryName,
                Guid = Guid.NewGuid()
            };
            return category;
        }
    }
}
