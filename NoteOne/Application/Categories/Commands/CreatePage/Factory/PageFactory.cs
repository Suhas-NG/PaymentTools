
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreatePage.Factory
{
    public class PageFactory : IPageFactory
    {
        public Page? Create(DateTime date, Category category, string pageTitle, string pageName)
        {
            if (category == null)
            {
                return null;
            }

            return new Page()
            {
                CategoryGuid = category.Guid,   
                Created = date,
                PageName = pageName,
                PageTitle = pageTitle
            };
        }
    }
}
