using System.Text.Json.Serialization;

namespace Routescan.Models.Common
{
    public class ErrorModel
    {
        [JsonPropertyName("statusCode")]
        public long StatusCode { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; } = "";

        [JsonPropertyName("error")]
        public string Error { get; set; } = "";

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";
    }
}
