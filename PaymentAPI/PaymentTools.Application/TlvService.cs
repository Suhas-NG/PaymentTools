using PaymentTools.Application.Helpers;
using PaymentTools.Application.Models;

namespace PaymentTools.Application.Services
{
    public class TlvService
    {
        private TlvParser _tlvParser;
        private TlvBuilder _tlvBuilder;

        public TlvService(  )
        {
            _tlvBuilder = new TlvBuilder();
            _tlvParser = new TlvParser();  
        }

        public List<Tlv> ParseTlv (string hexString)
        {
            List<Tlv> tlvs = new List<Tlv>();

            tlvs = _tlvParser.ParseHexString( hexString );

            return tlvs;
        }

    }
}
