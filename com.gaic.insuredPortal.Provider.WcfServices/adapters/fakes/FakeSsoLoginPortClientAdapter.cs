using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeSsoLoginPortClientAdapter : ISsoLoginPortClientAdapter
    {
        public string Login(string userid, string password)
        {
            return String.Format("TOEKNfor{0}", userid);
        }

        public void ClearToken()
        {
        }
    }
}