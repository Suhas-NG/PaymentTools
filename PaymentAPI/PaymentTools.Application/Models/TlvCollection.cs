using PaymentTools.Application.Helpers;

namespace PaymentTools.Application.Models
{
    public class TlvCollection
    {
        public TlvCollection(List<Tlv> tlvs)
        {
            this._tlvs = tlvs;
        }

        private List<Tlv> _tlvs = new List<Tlv>();
            
        public List<Tlv> Tlvs
        {
            get { return _tlvs; }
            set { _tlvs = value; }
        }
    }
}
