using Microsoft.AspNetCore.Mvc;
using NoteOne.Application.Categories.Commands.CreateCategory;
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
        public HomeController(IGetUserCategoriesQuery getUsersQuery, ICreateCategoryCommand createCategoryCommand)
        {
            _getUsersQuery = getUsersQuery;
            _createCategoryCommand = createCategoryCommand;
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

    }
}
