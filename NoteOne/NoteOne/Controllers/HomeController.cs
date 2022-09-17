using Microsoft.AspNetCore.Mvc;
using NoteOne.Application.Categories.Queries;
using NoteOne.Application.Queries;
using NoteOne.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {


        private readonly ICategoriesListQuery _query;
        public HomeController(ICategoriesListQuery query)
        {
            _query = query;
        }


        // GET: api/<HomeController>
        [HttpGet]
        public ActionResult<User> Index()
        {
            return Ok();
        }

    }
}
