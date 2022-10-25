using PaymentTools.Application.Models;
using PaymentTools.Application.Models.TlvDescriptionModel;

namespace PaymentTools.Application.Helpers
{
    public class TlvAnalyzer
    {
        private List<BaseTlvDescription> tlvDescriptions = new List<BaseTlvDescription>();

        public TlvAnalyzer()
        {
            tlvDescriptions = new List<BaseTlvDescription>()
            {
                new Tag9f33()
                //Add other tags with meaning here
            };
        }

        public void AnalyzePayload(TlvCollection tlv)
        {

        }
        public void AnalyzeTlvValue(Tlv tlv)
        {
            BaseTlvDescription tagDescription = tlvDescriptions.Where(u => u.tag == tlv.tag).FirstOrDefault();
            if (tagDescription == null)
            {
                tlv.tlvDetails = new SimpleTlvDetails(string.Empty, string.Empty);
                return;
            }

            string tlvBitLevelDetails = tagDescription.GetTlvDetails(tlv);
            tlv.tlvDetails = new SimpleTlvDetails(tlvBitLevelDetails, string.Empty); 
        }


    }
}
