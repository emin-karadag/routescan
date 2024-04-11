using Routescan.Core.Converters;
using Routescan.Core.Models;
using System.Text.Json.Serialization;

namespace Routescan.Models.Accounts
{
    public class HistoricalEtherBalanceModel : RoutescanBaseModel, IRoutescanModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        public long Result { get; set; }
    }
}
