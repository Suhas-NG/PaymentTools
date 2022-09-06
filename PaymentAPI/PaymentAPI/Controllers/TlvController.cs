using Microsoft.AspNetCore.Mvc;

namespace PaymentAPI.Controllers
{

    [ApiController]
    [Route("Api/Tlv")]
    public class TlvController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            return Ok("TLV parser");
        }

       
    }
}
