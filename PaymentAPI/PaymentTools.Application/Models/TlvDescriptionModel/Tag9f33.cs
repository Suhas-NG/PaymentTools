using PaymentTools.Common;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class Tag9f33 : BaseTlvDescription
    {
        
        public Tag9f33()
        {
            tagName = "Terminal Capabilites";

            TlvByteMeaning byteOne = new TlvByteMeaning()
            {
                byteEnum = ByteEnum.Byte1
                //new TlvBitInfo(BitEnum.Bit8, " );
            };
            TlvByteMeaning byteTwo = new TlvByteMeaning()
            {
                byteEnum = ByteEnum.Byte2
            };
            TlvByteMeaning byteThree = new TlvByteMeaning() 
            {
                byteEnum = ByteEnum.Byte3
            };
            tlvByteMeaning.Add(byteOne);
            tlvByteMeaning.Add(byteTwo);   
            tlvByteMeaning.Add(byteThree);
        }

        protected override bool InitializeTlv(Tlv tlv)
        {
            bool result = false;

            return result;
        }


    }
}
