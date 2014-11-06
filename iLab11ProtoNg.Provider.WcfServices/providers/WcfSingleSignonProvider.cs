using iLab11ProtoNg.Core.Domain.interfaces.provider;
using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.providers
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