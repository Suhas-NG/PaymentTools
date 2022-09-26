using NoteOne.Domain;

namespace NoteOne.Requests
{
    public class HomePageResponse
    {
        public Guid guid { get; set; }  
        public string name { get; set; }
        public string emailAddress { get; set; }
        public List<Category> mainCategories { get; set; }
    }
}
