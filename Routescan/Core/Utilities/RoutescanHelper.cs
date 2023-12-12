using System.Web;

namespace Routescan.Core.Utilities
{
    public class RoutescanHelper
    {
        internal const string VERSION = "v2";
        internal const string MAINNET_URL = $"https://api.routescan.io/{VERSION}/network/mainnet/evm";

        internal static Uri GetBaseUrl()
        {
            return new Uri($"{MAINNET_URL}{VERSION}");
        }

        internal static string GetRequestUrl(string url, string version = "")
        {
            version = string.IsNullOrEmpty(version) ? VERSION : version;
            return $"{MAINNET_URL}{version}{url}";
        }

        internal static string CreateQueryString(Dictionary<string, string>? parameters)
        {
            parameters ??= [];
            return $"?{string.Join("&", parameters.Where(p => !string.IsNullOrEmpty(p.Value))
                .Select(p => $"{p.Key}={HttpUtility.UrlEncode(p.Value)}"))}";
        }
    }
}
