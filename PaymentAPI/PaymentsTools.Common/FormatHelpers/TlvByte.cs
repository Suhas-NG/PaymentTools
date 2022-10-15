
namespace PaymentsTools.Common.FormatHelpers
{
    public class TlvByte
    {
        private int _byte = -1;

        public int GetByte()
        {
            return _byte;
        }

        public TlvByte(string hexByteString)
        {
            int upper = MapCharToByte(hexByteString[0]);
            int lower = MapCharToByte(hexByteString[1]);
            if (upper != -1 && lower != -1)
            {
                _byte = upper << 4 | lower;
            } else
            {
                throw new Exception(" unable to parse the hex string to byte "+hexByteString);
            }
        }
       
        public bool IsBitSet(int bitPos)
        {
            if (bitPos < 1 || bitPos > 8)
            {
                throw new Exception("Invalid bit pos");
            }
            else { 
                // if byte pos = 1 then 1 << 0
                return (_byte & (1 << bitPos -1 )) == (1<< bitPos -1);
            }
        }

        /// <summary>
        /// A quick map to speed up the execution 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private int MapCharToByte( char c)
        {
            switch (c)
            {
                case '0': return 0b00000000;
                case '1': return 0b00000001;
                case '2': return 0b00000010;
                case '3': return 0b00000011;
                case '4': return 0b00000100;
                case '5': return 0b00000101;
                case '6': return 0b00000110;
                case '7': return 0b00000111;
                case '8': return 0b00001000;
                case '9': return 0b00001001;
                case 'A': return 0b00001010;
                case 'B': return 0b00001011;
                case 'C': return 0b00001100;
                case 'D': return 0b00001101;
                case 'E': return 0b00001110;
                case 'F': return 0b00001111;
                default: return -1;
            }
        }
    }
}
