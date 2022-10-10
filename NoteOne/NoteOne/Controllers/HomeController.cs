using Microsoft.AspNetCore.Mvc;
using NoteOne.Application.Categories.Commands.CreateCategory;
using NoteOne.Application.Categories.Commands.CreateNote;
using NoteOne.Application.Categories.Commands.CreateNote.Factory;
using NoteOne.Application.Categories.Commands.CreatePage;
using NoteOne.Application.Categories.Queries;
using NoteOne.Application.Queries;
using NoteOne.Domain;
using NoteOne.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IGetUserCategoriesQuery _getUsersQuery;
        private readonly ICreateCategoryCommand _createCategoryCommand;
        private readonly ICreatePageCommand _createPageCommand;
        private readonly ICreateNoteCommand _createNoteCommand;
        public HomeController(IGetUserCategoriesQuery getUsersQuery, ICreateCategoryCommand createCategoryCommand, ICreatePageCommand createPageCommand, ICreateNoteCommand createNoteCommand)
        {
            _getUsersQuery = getUsersQuery;
            _createCategoryCommand = createCategoryCommand;
            _createPageCommand = createPageCommand;
            _createNoteCommand= createNoteCommand;
        }

        // GET: api/<HomeController>
        [HttpGet("Home/{id}")]
        public ActionResult<User> GetContents(Guid id)
        {
            User user = _getUsersQuery.Execute(id);
            return Ok(user);
        }

        [HttpPost("Home/{id}/Category")]
        public ActionResult CreateCategory(Guid id,[FromBody] CreateCategoryRequest request)
        {
            CreateCategoryModel createCategoryModel = new CreateCategoryModel()
            {
                categoryName = request.CategoryName,
                userId = id
            };
            var result = _createCategoryCommand.Execute(createCategoryModel);
            if (result == null)
            {
                return BadRequest();
            } else
            {
                return Ok(result); 
            }
        }

        [HttpPost("Home/{id}/CategoryPage")]
        public ActionResult CreatePage(Guid id, [FromBody] CreatePageRequest request)
        {
            CreatePageModel createPageModel = new CreatePageModel()
            {
                CategoryGuid = request.categoryGuid,
                pageName = request.pageName,
                pageTitle = request.pageTitle
                
            };
            var result = _createPageCommand.Execute(createPageModel);
            if (result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        } 

        [HttpPost("Home/{id}/PageNote")]
        public ActionResult CreateNote(Guid id, [FromBody] CreateNoteRequest request)
        {
            CreateNoteModel createNoteModel = new CreateNoteModel()
            {
                description = request.Description,
                pageGuid = id 
            };
            var result = _createNoteCommand.Execute(createNoteModel);
            if (result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        }

    }
}
