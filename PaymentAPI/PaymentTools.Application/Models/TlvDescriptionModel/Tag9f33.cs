
using PaymentTools.Application.Data;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class Tag9f33 : BaseTlvDescription
    {

        public Tag9f33()
        {
            bitNameMeanings = new List<BitNameMeaning>()
            {
                new BitNameMeaning(ByteEnum.Byte1, BitEnum.Bit8,"Manual Key Entry", Constants.DEFAULT_MEANING ),
                new BitNameMeaning(ByteEnum.Byte1, BitEnum.Bit7, "Magnetic Stripe", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte1, BitEnum.Bit6, "IC with Contacts", Constants.DEFAULT_MEANING),
                //RFUs
                new BitNameMeaning(ByteEnum.Byte2, BitEnum.Bit8, "Plaintext PIN for ICC verification", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte2, BitEnum.Bit7, "Enciphered PIN for Online verification", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte2, BitEnum.Bit6, "Signature Paper", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte2, BitEnum.Bit5, "Encrypted PIN for offline verification", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte2, BitEnum.Bit4, "No CVM required", Constants.DEFAULT_MEANING),
                
                new BitNameMeaning(ByteEnum.Byte3, BitEnum.Bit8, "SDA capable", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte3, BitEnum.Bit7, "DDA capable", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte3, BitEnum.Bit6, "Card Capture", Constants.DEFAULT_MEANING),
                new BitNameMeaning(ByteEnum.Byte3, BitEnum.Bit4, "CDA capable", Constants.DEFAULT_MEANING),

            };
            tagName = "9F33";
        }
        protected override bool InitializeTlv(Tlv tlv)
        {
            bool result = false;

            return result;
        }


    }
}
