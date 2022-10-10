
using NoteOne.Application.Categories.Commands.CreateNote.Factory;
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreateNote
{
    public interface ICreateNoteCommand
    {
        Note? Execute(CreateNoteModel createNoteModel);
    }
}
