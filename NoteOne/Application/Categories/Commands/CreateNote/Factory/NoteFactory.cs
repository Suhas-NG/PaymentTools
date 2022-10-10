
using NoteOne.Application.Categories.Commands.CreateNote.Factory;
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreateNote
{
    public class NoteFactory : INoteFactory
    {
        public Note? Create(DateTime dateTime, Page page, string description)
        {
            if (page == null)
            {
                return null;
            }
            var note = new Note()
            {
                Created = dateTime,
                Description = description,
                PageGuid = page.Guid
            };
            return note;
        }
    }
}
