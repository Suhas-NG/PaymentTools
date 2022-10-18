using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Model;
using PaymentTools.Application.Services;

namespace PaymentAPI.Controllers
{

    [ApiController]
    [Route("Api/Tlv")]
    public class TlvController : Controller
    {
        private TlvService _tlvService = new TlvService();

        [HttpPost()]
        public IActionResult Index([FromBody] TlvCompareRequest request )
        {
            var result = _tlvService.CompareTlvs(request.tlv1HexString, request.tlv2HexString);

            return Ok(result);
        }

       
    }
}
