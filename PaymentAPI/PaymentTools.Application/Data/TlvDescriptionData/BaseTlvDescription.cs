
using PaymentsTools.Common.FormatHelpers;
using System.Text;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public abstract class BaseTlvDescription
    {
        protected List<TlvByteMeaning> tlvByteMeaning = new List<TlvByteMeaning>() { };
        public string tagName = string.Empty;
        public string tag = string.Empty;   
        public string tagAdditionalInfo = string.Empty;
        public string GetTlvDetails(Tlv tlv)
        {
            StringBuilder stringBuilder = new StringBuilder();
            TlvBytes tlvBytes = new TlvBytes(tlv.value);

            tlvByteMeaning.ForEach(x =>
            {
                stringBuilder.AppendLine(x.byteEnum.ToString()+ " "+x.byteMeaning);   
                x.bitInfo.ForEach(bits =>
                {
                    stringBuilder.AppendLine( bits.bitNumber.ToString()+" "+bits.bitMeaning+"->" +tlvBytes.IsBitSet(x.byteEnum, bits.bitNumber).ToString());
               });
            });
            return stringBuilder.ToString();
        }
        
    }
}
