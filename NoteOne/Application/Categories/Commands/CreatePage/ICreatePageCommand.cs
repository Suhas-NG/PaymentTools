using NoteOne.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Application.Categories.Commands.CreatePage
{
    public interface ICreatePageCommand
    {
        Page? Execute(CreatePageModel model);
    }
}
