using PaymentTools.Common;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class Tag9f33 : BaseTlvDescription
    {
        public Tag9f33()
        {
            tag = "9F33";
            tagName = "Terminal Capabilites";

            TlvByteMeaning byteOne = new TlvByteMeaning()
            {
                byteMeaning = "card data input capability",
                byteEnum = ByteEnum.Byte1,
                bitInfo = new List<TlvBitInfo>()
                {
                    new TlvBitInfo(BitEnum.Bit8, "Manual Key Entry"),
                    new TlvBitInfo(BitEnum.Bit7, "Magnetic Stripe"),
                    new TlvBitInfo(BitEnum.Bit6, "IC with contact"),
                    new TlvBitInfo(BitEnum.Bit5, "RFU"),
                    new TlvBitInfo(BitEnum.Bit4, "RFU"),
                    new TlvBitInfo(BitEnum.Bit3, "RFU"),
                    new TlvBitInfo(BitEnum.Bit2, "RFU"),
                    new TlvBitInfo(BitEnum.Bit1, "RFU")
                }    
            };
            TlvByteMeaning byteTwo = new TlvByteMeaning()
            {
                byteMeaning = "CVM capability",
                byteEnum = ByteEnum.Byte2,
                bitInfo = new List<TlvBitInfo>()
                {
                    new TlvBitInfo(BitEnum.Bit8, "PlainText PIN for ICC verification"),
                    new TlvBitInfo(BitEnum.Bit7, "Enciphered PIN for onlinr verification"),
                    new TlvBitInfo(BitEnum.Bit6, "Signature (paper)"),
                    new TlvBitInfo(BitEnum.Bit5, "Enciphered Pin for online verification"),
                    new TlvBitInfo(BitEnum.Bit4, "No CVM required"),
                    new TlvBitInfo(BitEnum.Bit3, "RFU"),
                    new TlvBitInfo(BitEnum.Bit2, "RFU"),
                    new TlvBitInfo(BitEnum.Bit1, "RFU")  
                }
            };
            TlvByteMeaning byteThree = new TlvByteMeaning() 
            {
                byteMeaning = "Security Capability",
                byteEnum = ByteEnum.Byte3,
                bitInfo = new List<TlvBitInfo>()
                {
                    new TlvBitInfo(BitEnum.Bit8, "SDA"),
                    new TlvBitInfo(BitEnum.Bit7, "DDA"),
                    new TlvBitInfo(BitEnum.Bit6, "Card Capture"),
                    new TlvBitInfo(BitEnum.Bit5, "RFU"),
                    new TlvBitInfo(BitEnum.Bit4, "CDA"),
                    new TlvBitInfo(BitEnum.Bit3, "RFU"),
                    new TlvBitInfo(BitEnum.Bit2, "RFU"),
                    new TlvBitInfo(BitEnum.Bit1, "RFU")
                }
            };
            tlvByteMeaning.Add(byteOne);
            tlvByteMeaning.Add(byteTwo);   
            tlvByteMeaning.Add(byteThree);
        }
    }
}
