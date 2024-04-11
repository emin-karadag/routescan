using Routescan.Core.Results.Abstract;
using Routescan.Models.Accounts;
using Routescan.Models.Enums;

namespace Routescan.Business.Abstract.Accounts
{
    public interface IAccountsService
    {
        Task<IDataResult<BalanceModel?>> GetBalanceByAddressAsync(string address, ChainEnum chain = ChainEnum.ETHEREUM, TagEnum tag = TagEnum.LATEST, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<BalancesModel?>> GetBalanceByAddressAsync(List<string> addresses, ChainEnum chain = ChainEnum.ETHEREUM, TagEnum tag = TagEnum.LATEST, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<NormalTransactionsModel?>> GetNormalTransactionsByAddressAsync(string address, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByAddressAsync(string address, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByHashAsync(string hash, ChainEnum chain = ChainEnum.ETHEREUM, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByBlockRangeAsync(ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<ERC20TransferModel?>> GetListERC20TransfersByAddressAsync(string address, string contractAddress, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<ERC721TransferModel?>> GetListERC721TransfersByAddressAsync(string address, string contractAddress, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<ERC1155TransferModel?>> GetListERC1155TransfersByAddressAsync(string address, string contractAddress, ChainEnum chain = ChainEnum.ETHEREUM, long startBlock = 0, long endBlock = 99999999, int page = 1, int offset = 10, SortEnum sort = SortEnum.ASC, string apiKey = "", CancellationToken ct = default);
        Task<IDataResult<HistoricalEtherBalanceModel?>> GetHistoricalEtherBalanceByBlockNoAsync(string address, long blockNo, ChainEnum chain = ChainEnum.ETHEREUM, string apiKey = "", CancellationToken ct = default);
    }
}
