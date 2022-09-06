using NUnit.Framework;
using System.Text;

namespace NoteOne.Persistence.PersistenceTest
{
    [TestFixture]
    public class UnitTestDataAccess
    {
        private void GetUsers()
        {
            StringBuilder stringBuilder = new StringBuilder();
            using var context = new NoteOneDbContext();
            var users = context?.Users?.ToList();
            foreach (var user in users)
            {
                stringBuilder.Append(user.UserName+" "+user.Password+" "+user.Guid);
            }

        }

        [Test]
        public void TestPostgresConnection()
        {
            using (NoteOneDbContext context = new NoteOneDbContext())
            {
                context.Database.EnsureCreated();
            }
            GetUsers();
            Assert.True(true);
        }
    }
}
