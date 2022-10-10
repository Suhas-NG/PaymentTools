using NoteOne.Application.Categories.Commands.CreatePage.Factory;
using NoteOne.Application.Interfaces;
using NoteOne.Common.Dates;
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreatePage
{
    public class CreatePageCommand : ICreatePageCommand
    {
        private readonly IDateService _dateService;
        private readonly IPageRepository _pageRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPageFactory _pageFactory;
        public CreatePageCommand(IDateService dateService, IPageRepository pageRepository, ICategoryRepository categoryRepository, IPageFactory pageFactory)
        {
           _dateService = dateService;
           _pageRepository = pageRepository;
           _categoryRepository = categoryRepository;
           _pageFactory = pageFactory;
        }
        public Page? Execute(CreatePageModel model)
        {
            var category = _categoryRepository.Get(model.CategoryGuid);
            if (category == null)
            {
                return null;
            }

            var createDate = _dateService.GetDateTime();
            var newPage = _pageFactory.Create(createDate, category, model.pageName, model.pageTitle);
            if (newPage != null)
            {
                Page? result = _pageRepository.Add(newPage);
                _pageRepository.Save();
                return result;
            }
            return null;
        }
    }
}
