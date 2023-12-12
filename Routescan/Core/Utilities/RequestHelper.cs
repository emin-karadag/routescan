using Routescan.Core.Results.Abstract;
using Routescan.Core.Results.Concrete;
using Routescan.Models.Common;
using Routescan.Models.Enums;
using System.Net;
using System.Net.Http.Json;

namespace Routescan.Core.Utilities
{
    public static class RequestHelper
    {
        public static async Task<IDataResult<T?>> SendRequestAsync<T>(Dictionary<string, string>? parameters = null, ChainEnum chain = ChainEnum.ETHEREUM, CancellationToken ct = default)
        {
            try
            {
                using var httpClient = new HttpClient();

                var queryString = RoutescanHelper.CreateQueryString(parameters);
                var uriBuilder = new UriBuilder($"{RoutescanHelper.MAINNET_URL}/{chain.GetDisplayName()}/etherscan/api");
                if (parameters?.Count > 0)
                    uriBuilder.Query = queryString;

                var response = await httpClient.GetAsync(uriBuilder.Uri, ct);
                if (response.StatusCode == HttpStatusCode.OK)
                {
#if DEBUG
                    var res = await response.Content.ReadAsStringAsync(ct);
#endif
                    var data = await response.Content.ReadFromJsonAsync<T?>(cancellationToken: ct);
                    return new SuccessDataResult<T?>(data);
                }
                else
                {
                    var data = await response.Content.ReadFromJsonAsync<ErrorModel?>(cancellationToken: ct);
                    return new ErrorDataResult<T?>(data?.Message ?? "");
                }
            }
            catch (HttpRequestException ex)
            {
                // İsteği gönderirken bir hata oluştu
                return new ErrorDataResult<T?>(ex.Message);
            }
            catch (TaskCanceledException ex)
            {
                // İşlem iptal edildi
                return new ErrorDataResult<T?>(ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer hatalar
                return new ErrorDataResult<T?>(ex.Message);
            }
        }

    }
}
