

namespace PaymentTools.Application.Models
{
    public interface ITlvDetails
    {
        string GetDetails { get; }
        string GetTagName { get; }  
        string GetValueDetailsString { get; }
        Dictionary<string, BitNameMeaning> tagValueDetails { get; }
    }
}
