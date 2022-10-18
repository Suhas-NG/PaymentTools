using PaymentTools.Common;

namespace PaymentsTools.Common.FormatHelpers
{
    public class TlvBytes
    {
        public List<TlvByte> _bytes = new List<TlvByte>();
        public TlvBytes(string hexString)
        {
            _bytes = HexStringList(hexString);
        }

        public bool IsBitSet(ByteEnum byteEmum, BitEnum bitNumber)
        {
            int byteNumber = (int)byteEmum;
            return _bytes[byteNumber].IsBitSet((int)bitNumber); 
        }

        private List<TlvByte> HexStringList(string str)
        {
            return Enumerable.Range(0, str.Length / 2)
                .Select(i => new TlvByte(str.Substring(i * 2, 2))).ToList();
        }
    }
}
