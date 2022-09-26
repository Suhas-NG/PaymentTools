using Microsoft.EntityFrameworkCore;
using NoteOne.Application.Interfaces;
using NoteOne.Domain;
using NoteOne.Persistence;

namespace NoteOne.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRespository
    {
        public UserRepository():base(new NoteOneDBContext())
        {
        }

        public void Delete(Guid id)
        {
            context.Remove(id);
        }

        public User Get(string email)
        {
            var user = context?.Users?.Single(x => x.Email == email);
            return user;
        }

        public User GetUserWithDetails(Guid id)
        {
            var user = context.Users.Include(u => u.Categories)
                .ThenInclude(c => c.Pages)
                .Where(u => u.Guid == id).First();
            return user;
        }


        public void Save()
        {
            base.SaveChanges();
        }

        public override User Get(Guid id)
        {
            return context.Users.Where(u => u.Guid == id)
                .First();
        }
        public override User Update(User entity)
        {
            var user = context?.Users?
                .Single(u => u.Guid == entity.Guid);

           if( user == null )
                throw new Exception("Unable to Update Users");
           
            user.UserName = entity.UserName;
            return base.Update(user);
        }
    }
}
