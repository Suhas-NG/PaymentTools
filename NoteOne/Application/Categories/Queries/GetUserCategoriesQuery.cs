using NoteOne.Application.Interfaces;
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Queries
{
    public class GetUserCategoriesQuery : IGetUserCategoriesQuery
    {
        public IUserRespository _userRepository;
        public GetUserCategoriesQuery(IUserRespository userRespository)
        {
            _userRepository = userRespository;
        }
        public User Execute(Guid userGuid)
        {
            User user = _userRepository.GetUserWithDetails(userGuid);
            return user;
        }
    }
}
