using NoteOne.Domain;

namespace NoteOne.Application.RepositoriesLocalDB
{
    public class LocalDbContext
    {

        public bool HasChanged = false;
        public List<Category>? Categories { get; set; } = new List<Category>();
        public List<Note>? Notes { get; set; } = new List<Note>();
        public List<Page>? Pages { get; set; } = new List<Page>();
        public List<Tag>? Tags { get; set; } = new List<Tag>();
        public List<User>? Users { get; set; } = new List<User>();  

    }
}
