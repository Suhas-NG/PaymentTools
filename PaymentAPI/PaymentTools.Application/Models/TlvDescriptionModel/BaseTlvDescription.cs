
using PaymentsTools.Common.FormatHelpers;
using System.Text;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public abstract class BaseTlvDescription
    {
        protected List<BitNameMeaning> bitNameMeanings;
        protected Tlv tlv { get; set; }
        protected string tagName;
        protected string GetTlvDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            TlvBytes tlvBytes = new TlvBytes(tlv.value);
            bitNameMeanings.ForEach(bitNameMeanings =>
            {
                string byteString = tlv.value;
                stringBuilder.AppendLine("Byte"+(int)bitNameMeanings.byteNumber+" Bit"+(int)bitNameMeanings.bitEnum
                    +" value= "+tlvBytes.IsBitSet(bitNameMeanings.byteNumber, bitNameMeanings.bitEnum)?" 1 ": " 0 "
                    +" name: "+bitNameMeanings.name +" "+bitNameMeanings.meaning) ; 
            });
            return stringBuilder.ToString();
        }
        
        protected abstract bool InitializeTlv(Tlv tlv);    

    }
}
