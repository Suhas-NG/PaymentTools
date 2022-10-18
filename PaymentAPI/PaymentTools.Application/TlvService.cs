using PaymentTools.Application.Helpers;
using PaymentTools.Application.Models;

namespace PaymentTools.Application.Services
{
    public class TlvService
    {
        private TlvParser _tlvParser;
        private TlvBuilder _tlvBuilder;
        private TlvCompare _tlvCompare;

        public TlvService(  )
        {
            _tlvBuilder = new TlvBuilder();
            _tlvParser = new TlvParser(); 
            _tlvCompare = new TlvCompare();
        }

        public List<Tlv> ParseTlv (string hexString)
        {
            List<Tlv> tlvs = new List<Tlv>();

            tlvs = _tlvParser.ParseHexString( hexString );

            return tlvs;
        }

        public List<TlvCompareTree> CompareTlvs(string tlv1HexString, string tlv2HexString)
        {
            List<TlvCompareTree> tlvCompareTrees = new List<TlvCompareTree>();
            List<Tlv> tlv1 = _tlvParser.ParseHexString(tlv1HexString);
            List<Tlv> tlv2 = _tlvParser.ParseHexString(tlv2HexString);
            tlvCompareTrees = _tlvCompare.ComparerTlvCollection(tlv1, tlv2);
            return tlvCompareTrees;
        }
       

    }
}
