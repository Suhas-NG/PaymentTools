using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryModel
    {
        public string categoryName { get; set; } = string.Empty;
        public Guid categoryId { get; set; }
        public Guid userId { get; set; }
    }
}
