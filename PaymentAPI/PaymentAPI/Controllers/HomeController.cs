using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentAPI.Controllers
{
    [ApiController] // automatic 404 etcs
    [Route("Api/Home")]
    public class HomeController : ControllerBase
    {
        [HttpGet()]
        public JsonResult GetNames()
        {
            return new JsonResult(
                new List<object> { new { id=1, Name= "NYC"},
                    new { id=2, Name = "Antwerp" } }); 
        } 

    }
}
