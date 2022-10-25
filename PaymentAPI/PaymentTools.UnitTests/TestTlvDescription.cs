using PaymentTools.Application.Helpers;
using PaymentTools.Application.Models;
using System.Collections.Generic;
using Xunit;

namespace PaymentTools.UnitTests
{

    public class TestTlvDescription
    {
        TlvAnalyzer _tlvAnalyzer = new TlvAnalyzer();
        TlvParser _tlvParser = new TlvParser();

        [Fact]
        public void testTerminalCapabilitesDescription(){
            List<Tlv> parsedTlv = _tlvParser.ParseHexString("9F33036008C8");
            //    0110-0000 0000-1000 1100-1000
            //    Magnetic stripe, IC with contacts = > true 
            //    No CVM required => True 
            //    SDA DDA CDA capable but not card capture
             _tlvAnalyzer.AnalyzeTlvValue(parsedTlv[0]);
            string tlvDescriptions = parsedTlv[0].tlvDetails.GetDetails();
        }

        [Fact]
        public void testNoDescriptionTlv()
        {
            List<Tlv> parsedTlv = _tlvParser.ParseHexString("4F0101");
            _tlvAnalyzer.AnalyzeTlvValue(parsedTlv[0]);
            string tlvDescriptions = parsedTlv[0].tlvDetails.GetDetails();
        }
        
    }
}
