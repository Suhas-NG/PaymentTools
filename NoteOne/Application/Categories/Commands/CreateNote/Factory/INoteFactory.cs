
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreateNote.Factory
{
    public interface INoteFactory
    {
        Note? Create(DateTime dateTime, Page page, string description);
    }
}
