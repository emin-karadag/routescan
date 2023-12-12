using Routescan.Business.Abstract;
using Routescan.Business.Abstract.Accounts;
using Routescan.Business.Concrete.Accounts;

namespace Routescan.Business.Concrete
{
    public class RoutescanManager : IRoutescanService
    {
        public RoutescanManager()
        {
            AccountsApi = new AccountsManager();
        }

        public IAccountsService AccountsApi { get; set; }
    }
}
