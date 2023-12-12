using Routescan.Core.Converters;
using Routescan.Core.Models;
using System.Text.Json.Serialization;

namespace Routescan.Models.Accounts
{
    public class BalanceModel : RoutescanBaseModel, IRoutescanModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Result { get; set; }
    }
}
