namespace PaymentTools.Application.Models
{
    public class BitNameMeaning
    {
        public BitNameMeaning(ByteEnum byteNumber, BitEnum bitEnum, string name, string meaning)
        {
            this.bitEnum = bitEnum;
            this.name = name;
            this.meaning = meaning;
            this.byteNumber = byteNumber;
        }
        public BitEnum bitEnum  = BitEnum.Null;
        public string name = string.Empty;
        public string meaning = string.Empty;
        public ByteEnum byteNumber = ByteEnum.Null;
    }

  
}