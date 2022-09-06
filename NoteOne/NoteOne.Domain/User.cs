namespace NoteOne.Domain
{
    public class User : IEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Category> Categories { get; set; }
        public Guid Guid { get; set; }
               
    }
}