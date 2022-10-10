namespace NoteOne.Requests
{
    public class CreatePageRequest
    {
        public string pageName { get; set; }   
        public string pageTitle { get; set; } 
        public Guid categoryGuid { get; set; }   
    }
}
