using NoteOne.Domain;


namespace NoteOne.Application.Interfaces
{
    public interface IUserRespository
    {
        User Get(Guid id);
        User Get(string email);
        User GetUserWithDetails(Guid id);
        User Add(User user);
        User Update(User user);
        void Delete(Guid id);
        void Save();
    }
}
