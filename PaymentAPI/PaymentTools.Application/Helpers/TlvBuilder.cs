
using PaymentTools.Application.Models;

namespace PaymentTools.Application.Services
{
    public class TlvBuilder
    {
        public Tlv BuildEmptyTlv()
        {
            return new Tlv("", "",0, "", new List<Tlv>());
        }
        public string BuildTlvHexString()
        {
            string tlv = string.Empty;
            
            return tlv;
        }

    }
}
