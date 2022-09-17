using NoteOne.Application.Categories.Commands.CreateCategory.Factory;
using NoteOne.Application.Interfaces;
using NoteOne.Common.Dates;

namespace NoteOne.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : ICreateCategoryCommand
    {
        private readonly IDateService _dateService;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRespository _userRepository;
        private readonly ICategoryFactory _categoryFactory;
        public CreateCategoryCommand(IDateService dateService, ICategoryRepository categories, IUserRespository userRepository, ICategoryFactory categoryFactory)
        {
            _dateService = dateService;
            _categoryRepository = categories;
            _userRepository = userRepository;
            _categoryFactory = categoryFactory;
        }
        public bool Execute(CreateCategoryModel model)
        {
            var user = _userRepository.Get(model.userId);
            var createDate = _dateService.GetDateTime();
            var newCategory = _categoryFactory.Create(createDate, user, model.categoryName);
            if (newCategory != null)
            {
                bool result = _categoryRepository.Add(newCategory);
                 _categoryRepository.Save();
                return result;
            }
            return false;
        }
    }
}
