using Routescan.Business.Abstract.Accounts;
using Routescan.Core.Results.Abstract;
using Routescan.Core.Results.Concrete;
using Routescan.Core.Utilities;
using Routescan.Models.Accounts;
using Routescan.Models.Enums;

namespace Routescan.Business.Concrete.Accounts
{
    public class AccountsManager : IAccountsService
    {
        public async Task<IDataResult<BalanceModel?>> GetBalanceByAddressAsync(string address, ChainEnum chain = ChainEnum.ETHEREUM, TagEnum tag = TagEnum.LATEST, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "balance" },
                    { "address", address },
                    { "tag", tag.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<BalanceModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<BalanceModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<BalancesModel?>> GetBalanceByAddressAsync(List<string> addresses, ChainEnum chain = ChainEnum.ETHEREUM, TagEnum tag = TagEnum.LATEST, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "balancemulti" },
                    { "address", string.Join(",",addresses) },
                    { "tag", tag.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<BalancesModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<BalancesModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<NormalTransactionsModel?>> GetNormalTransactionsByAddressAsync(string address, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlist" },
                    { "address", string.Join(",",address) },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<NormalTransactionsModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<NormalTransactionsModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByAddressAsync(string address, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlistinternal" },
                    { "address", string.Join(",",address) },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<InternalTransactionsModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<InternalTransactionsModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByHashAsync(string hash, ChainEnum chain = ChainEnum.ETHEREUM, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlistinternal" },
                    { "txhash", hash },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<InternalTransactionsModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<InternalTransactionsModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByBlockRangeAsync(ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlistinternal" },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<InternalTransactionsModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<InternalTransactionsModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<ERC20TransferModel?>> GetListERC20TransfersByAddressAsync(string address, string contractAddress, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "tokentx" },
                    { "address", address },
                    { "contractAddress", contractAddress },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<ERC20TransferModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ERC20TransferModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<ERC721TransferModel?>> GetListERC721TransfersByAddressAsync(string address, string contractAddress, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "tokennfttx" },
                    { "address", address },
                    { "contractAddress", contractAddress },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<ERC721TransferModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ERC721TransferModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<ERC1155TransferModel?>> GetListERC1155TransfersByAddressAsync(string address, string contractAddress, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "token1155tx" },
                    { "address", address },
                    { "contractAddress", contractAddress },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort.GetDisplayName() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<ERC1155TransferModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ERC1155TransferModel?>(ex.Message);
            }
        }

        public async Task<IDataResult<HistoricalEtherBalanceModel?>> GetHistoricalEtherBalanceByBlockNoAsync(string address, long blockNo, ChainEnum chain = ChainEnum.ETHEREUM, string apiKey = "", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "balancehistory" },
                    { "address", address },
                    { "blockno", blockNo.ToString() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<HistoricalEtherBalanceModel>(parameters, chain, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<HistoricalEtherBalanceModel?>(ex.Message);
            }
        }
    }
}
