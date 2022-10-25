using PaymentTools.Common;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class TlvBitInfo
    {
        public TlvBitInfo(BitEnum bit, string meaning )
        {
            bitNumber = bit;
            bitMeaning = meaning;
        }

        public BitEnum bitNumber = BitEnum.Null;
        public string bitMeaning = string.Empty;
        public string bitValue = string.Empty;
    }
}
