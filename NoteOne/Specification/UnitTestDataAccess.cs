using NoteOne.Domain;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteOne.Persistence.PersistenceTest
{
    public class UnitTestDataAccess
    {

        [SetUp]
        public void initialize()
        {
            using (NoteOneDBContext context = new NoteOneDBContext())
            {
                context.Database.EnsureCreated();
            }
        }
        //private void GetUsers()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    using var context = new NoteOneDBContext();
        //    var users = context?.Users?.ToList();
        //    foreach (User user in users)
        //    {
        //        stringBuilder.Append(user.UserName+" "+user.Password+" "+user.Guid);
        //    }

        //}

        //private void AddUsers()
        //{
        //    var user = new User()
        //    {
        //        UserName = "testUser",
        //        Password = "password"
        //    };
        //    using var context = new NoteOneDBContext();
        //    context.Add(user);
        //    context.SaveChanges();
        //}

        //[Test]
        //public void TestPostgresConnection()
        //{
        //    GetUsers();
        //    Assert.True(true);
        //}

        //[Test]
        //public void TestAddUser()
        //{

        //    AddUsers();
        //    Assert.True(true);
        //}

        //[Test]
        //public void TestAddUserWithCategory()
        //{
        //    var user = new User()
        //    {
        //        UserName = "testUser",
        //        Password = "password",
        //        Categories = new List<Category>() { new Category() 
        //           { 
        //            CategoryName="Work Stuff",
        //            Pages = new List<Page>()
        //            {
        //                new Page() 
        //                {
        //                    PageName = "Emv",
        //                    PageTitle = "Sale",
        //                    Notes = new List<Note>()
        //                    {
        //                        new Note()
        //                        {
        //                            Created = System.DateTime.UtcNow,
        //                            Description = "Sale transactions cost 30$"
        //                        }
        //                    }
        //                }
        //            }
        //           } 
        //        }
        //    };


        //    using var context = new NoteOneDBContext();
        //    context.Add(user);
        //    context.SaveChanges();
        //}
    }
}
