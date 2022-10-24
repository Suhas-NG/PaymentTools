using PaymentTools.Common;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class TlvBitInfo
    {
        public TlvBitInfo(BitEnum bit, string meaning, string value )
        {
            bitNumber = bit;
            bitMeaning = meaning;
            bitValue = value;
        }

        public BitEnum bitNumber = BitEnum.Null;
        public string bitMeaning = string.Empty;
        public string bitValue = string.Empty;
    }
}
