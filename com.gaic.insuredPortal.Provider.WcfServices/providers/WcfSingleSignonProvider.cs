using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfSingleSignonProvider : ISingleSignonProvider
    {
        private readonly ISsoLoginPortClientAdapter _ssoLoginPortClientAdapter;

        public WcfSingleSignonProvider(ISsoLoginPortClientAdapter ssoLoginPortClientAdapter)
        {
            _ssoLoginPortClientAdapter = ssoLoginPortClientAdapter;
        }

        public string GetSingleSignonToken(string userName, string pwd)
        {
            return _ssoLoginPortClientAdapter.Login(userName, pwd);
        }
    }
}