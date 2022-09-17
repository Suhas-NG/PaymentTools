using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Application.Categories.Commands.CreateCategory
{
    public interface ICreateCategoryCommand
    {
        bool Execute(CreateCategoryModel model);
    }
}
