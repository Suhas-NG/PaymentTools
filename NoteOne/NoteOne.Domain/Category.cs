
namespace NoteOne.Domain
{
    public class Category : IEntity
    {
        public string CategoryName { get; set; } = string.Empty;
        public List<Page>? Pages { get; set; }
        public Guid Guid { get; set; }
    }
}
