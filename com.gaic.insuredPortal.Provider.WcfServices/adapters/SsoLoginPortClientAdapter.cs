using System;
using System.Net;
using System.Security.Authentication;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class SsoLoginPortClientAdapter : ISsoLoginPortClientAdapter, IDisposable
    {
        private readonly SSOLoginPortClient _ssoLoginPortClient;

        public SsoLoginPortClientAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _ssoLoginPortClient = new SSOLoginPortClient(bindingAdapter.Binding, endpointAddressAdapter.EndpointAddress);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string Login(string userid, string password)
        {
            if (userid == null || password == null)
                throw new AuthenticationException("Invalid credentials from the request");

            ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
            if (_ssoLoginPortClient.ClientCredentials != null)
            {
                if (string.IsNullOrEmpty(_ssoLoginPortClient.ClientCredentials.UserName.UserName))
                {
                    _ssoLoginPortClient.ClientCredentials.UserName.UserName = userid;
                    _ssoLoginPortClient.ClientCredentials.UserName.Password = password;
                }
            }
            string token = _ssoLoginPortClient.login();
            return token;
        }

        public void ClearToken()
        {
            if (_ssoLoginPortClient.ClientCredentials == null) return;

            _ssoLoginPortClient.ClientCredentials.UserName.UserName = null;
            _ssoLoginPortClient.ClientCredentials.UserName.Password = null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _ssoLoginPortClient.Close();
            }
            // free native resources
        }
    }
}