using NoteOne.Application.Categories.Commands.CreateNote.Factory;
using NoteOne.Application.Interfaces;
using NoteOne.Common.Dates;
using NoteOne.Domain;

namespace NoteOne.Application.Categories.Commands.CreateNote
{
    public class CreateNoteCommand : ICreateNoteCommand
    {
        private readonly IDateService _dateService;
        private readonly INoteRepository _noteRepository;
        private readonly IPageRepository _pageRepository;
        private readonly INoteFactory _noteFactory;
        public CreateNoteCommand(IDateService dateService, INoteFactory noteFactory, IPageRepository pageRepository, INoteRepository noteRepository)
        {
            _dateService= dateService;
            _noteRepository= noteRepository;
            _noteFactory= noteFactory;
            _pageRepository= pageRepository;
        }

        public Note? Execute(CreateNoteModel createNoteModel)
        {
            var page = _pageRepository.Get(createNoteModel.pageGuid);
            if (page == null)
            {
                return null;
            }
            var createDate = _dateService.GetDateTime();
            var newNote = _noteFactory.Create(createDate, page, createNoteModel.description);   
            if (newNote != null)
            {
                Note? result = _noteRepository.Add(newNote);
                _noteRepository.Save();
                return result;
            }
            return null;
        }
    }
    
}
