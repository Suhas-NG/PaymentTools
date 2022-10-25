using PaymentTools.Common;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class TlvByteMeaning
    {
        public ByteEnum byteEnum = ByteEnum.Null;
        public string byteMeaning = string.Empty;
        public List<TlvBitInfo> bitInfo = new List<TlvBitInfo>();  
    }
}
