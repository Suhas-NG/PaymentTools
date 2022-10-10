
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreatePage.Factory
{
    public interface IPageFactory
    {
        Page? Create(DateTime date, Category category, string pageTitle, string pageName);

    }
}
