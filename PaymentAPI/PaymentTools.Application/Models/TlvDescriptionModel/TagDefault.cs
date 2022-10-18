using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTools.Application.Models.TlvDescriptionModel
{
    public class TagDefault : BaseTlvDescription
    {
        public TagDefault()
        {
            tagName = "";
        }
        protected override string GetTlvDetails()
        {
            return string.Empty;
        }

        protected override bool InitializeTlv(Tlv tlv)
        {
            bool result = false;
            return result;
        }
    }
}
