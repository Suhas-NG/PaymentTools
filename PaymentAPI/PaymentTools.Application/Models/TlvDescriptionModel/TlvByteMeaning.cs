using PaymentTools.Common;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class TlvByteMeaning
    {
        public ByteEnum byteEnum = ByteEnum.Null;
        public List<TlvBitInfo> bitInfo = new List<TlvBitInfo>();  
    }
}
