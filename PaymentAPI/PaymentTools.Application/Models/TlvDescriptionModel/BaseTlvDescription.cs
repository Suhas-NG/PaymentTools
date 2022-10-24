
using PaymentsTools.Common.FormatHelpers;
using System.Text;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public abstract class BaseTlvDescription
    {
        protected List<TLvValueDescription> bitNameMeanings;
        protected List<TlvByteMeaning> tlvByteMeaning = new List<TlvByteMeaning>() { };
        protected Tlv tlv { get; set; }
        protected string tagName;
        protected string tagDescription;
        protected string GetTlvDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            TlvBytes tlvBytes = new TlvBytes(tlv.value);

            tlvByteMeaning.ForEach(x =>
            {
                stringBuilder.Append("Byte Number: " + x.byteEnum.ToString());   
                x.bitInfo.ForEach(bits =>
                {
                    stringBuilder.AppendLine( "Bit"+ bits.bitNumber.ToString()+" "+bits.bitMeaning+"->" +tlvBytes.IsBitSet(x.byteEnum, bits.bitNumber).ToString());
               });
            });

            tagDescription = stringBuilder.ToString();  
            return stringBuilder.ToString();
        }
        
        protected abstract bool InitializeTlv(Tlv tlv);    
    }
}
