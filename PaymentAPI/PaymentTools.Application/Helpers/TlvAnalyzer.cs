using PaymentTools.Application.Models;
using PaymentTools.Application.Models.TlvDescriptionModel;

namespace PaymentTools.Application.Helpers
{
    public class TlvAnalyzer
    {
        public BaseTlvDescription AnalyzeDescription(Tlv tlv)
        {
            return new Tag9f33();   
        }
    }
}
