

namespace PaymentsTools.Common.FormatHelpers
{
    public static class ByteExtensions
    {
        public static bool IsBitSet (this byte input, int bitPos)
        {
           return (input & (1 << bitPos - 1)) == (1 << bitPos - 1);
        }
    }
}
