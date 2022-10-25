

namespace PaymentTools.Application.Models
{
    public interface ITlvDetails
    {
        /// <summary>
        /// 
        /// Reads the tlv value bits and interprets the result
        /// </summary>
        /// <returns></returns>
        string GetDetails();

        /// <summary>
        /// this should return other comments regarding the tlv values or statues
        /// </summary>
        /// <returns></returns>
        string GetAdditionalDetails();
    }
}
