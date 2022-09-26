using NoteOne.Domain;

namespace NoteOne.Application.Queries
{
    public interface IGetUsersListQuery
    {
        List<User> Execute();
    }
}
