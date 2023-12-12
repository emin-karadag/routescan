using Routescan.Business.Abstract.Accounts;

namespace Routescan.Business.Abstract
{
    public interface IRoutescanService
    {
        public IAccountsService AccountsApi { get; set; }
    }
}
