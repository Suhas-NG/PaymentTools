
namespace PaymentTools.Application.Models
{
    public class Tlv
    {
        public Tlv(string tag, string lengthString, int lengthValue, string value, List<Tlv> subTlvs )
        {
            this.tag = tag;
            this.lengthString = lengthString;
            this.lengthValue = lengthValue;
            this.value = value; 
            if (subTlvs.Count > 0)
            {
                hasNestedTlvs = true;
                this.nestedTlvs = new TlvCollection(subTlvs);
            }
        }

        public ITlvDetails tlvDetails { get; set; }
        public string tag { get; set; } 
        public string lengthString { get; set; }
        public int lengthValue { get; set; }
        public string value { get; set; }
        public bool hasNestedTlvs { get; set; }
        public TlvCollection nestedTlvs  { get; set; }   

    }
}
