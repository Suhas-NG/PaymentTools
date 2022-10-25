using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTools.Application.Models
{
    public class SimpleTlvDetails : ITlvDetails
    {
        private string _tlvDetails;
        private string _additionalDetails;

        public SimpleTlvDetails()
        {
            _tlvDetails = string.Empty;
            _additionalDetails = string.Empty;  
        }

        public SimpleTlvDetails(string tlvDetails, string additionalDetails)
        {
            this._tlvDetails = tlvDetails;
            this._additionalDetails = additionalDetails;
        }
        public string GetDetails()
        {
            return _tlvDetails;
        }

        public string GetAdditionalDetails()
        {
            return this._additionalDetails;
        }

     }
}
