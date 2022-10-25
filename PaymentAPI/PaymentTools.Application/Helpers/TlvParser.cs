using PaymentsTools.Common.FormatHelpers;
using PaymentTools.Application.Data;
using PaymentTools.Application.Models;


namespace PaymentTools.Application.Helpers
{
    public class TlvParser
    {
        private const int MAX_TAG_LENGTH_COUNT = 10;
        private const int MAX_NESTED_TAG_RECURSION = 3;
        private  List<byte> StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToList();
        }
        public  List<Tlv> ParseHexString(string tlvHexString, int recursionCount = 0)
        {  
            List<Tlv> result = new List<Tlv>();
            if (tlvHexString == null || tlvHexString.Length  < 3)
            {
                return result;
            }

            tlvHexString = tlvHexString.ToUpper();
            List<byte> tlvBytes = StringToByteArray(tlvHexString);

            int i = 0;
            while(i < tlvBytes.Count())
            {
                byte currentByte = tlvBytes[i];
                string tag = currentByte.ToString("X2");
                bool isNestedTag = currentByte.IsBitSet(6);
                if ((currentByte & 0b00011111) == 31)
                {
                    do
                    {
                        i++;
                        currentByte = tlvBytes[i];
                        tag = tag + currentByte.ToString("X2");

                        if (tag.Length > MAX_TAG_LENGTH_COUNT) throw new Exception("Tag length above max");
                    } while (currentByte.IsBitSet(8)); 
                }
                
                //Special tags
                if (tag =="57" || tag =="5A" && i+1 < tlvBytes.Count())
                {
                    string nextByte = tag + tlvBytes[i+1].ToString("X2");
                    if(Constants.SPECIAL_TAGS.Contains(nextByte))
                    {
                        i++;
                        tag = nextByte;
                    }    
                }

                string tagName = TagNames.GetName(tag);

                //length
                i++;
                currentByte = tlvBytes[i];
                //if the b8 is 0
                string length = currentByte.ToString("X2");
                if (currentByte.IsBitSet(8))
                {
                   int numberOfSubsequentBytes = currentByte & 0b01111111;
                   while(numberOfSubsequentBytes-- > 0)
                   {
                        i++;
                        length = length + tlvBytes[i].ToString("X2");
                    }
                }

                int lenthOfValues = getLengthValue(length);
                int lengthSave = lenthOfValues;
                string value = string.Empty;

                while (lenthOfValues-- >0)
                {
                    i++;
                    value = value + tlvBytes[i].ToString("X2");
                }

                List<Tlv> nestedTlvs = new List<Tlv>();
                if (isNestedTag && recursionCount < MAX_NESTED_TAG_RECURSION)
                {
                    recursionCount++;
                    nestedTlvs = ParseHexString(value, recursionCount);
                }

                Tlv resultTlv = new Tlv(tag, length, lengthSave, value, nestedTlvs);
                resultTlv.tagName = tagName;    
                result.Add(resultTlv);
                i++;
            }   
            return result;
        }

        private void IdentifyValue()
        {

        }
        private void IdentifyTag()
        {

        }

        public int getLengthValue(string lengthString)
        {
            int result= 0;

            List<byte> tlvBytes = StringToByteArray(lengthString);

            if (!tlvBytes[0].IsBitSet(8))
            {
                result = tlvBytes[0];
            } else
            {
                int subsequentBytes = tlvBytes[0] & 0b01111111; //2 82  82 [FF] [FF]
                int value = tlvBytes[1];

                int i = 2;
                while (--subsequentBytes > 0)
                {
                    value = value << 8;
                    value = value + tlvBytes[i];
                    i++;
                }
                result = value;
            }
            return result;
        }
       
    }
}
