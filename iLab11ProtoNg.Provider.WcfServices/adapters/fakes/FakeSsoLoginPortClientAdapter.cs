using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.adapters.fakes
{
    public class FakeSsoLoginPortClientAdapter : ISsoLoginPortClientAdapter
    {
        public string Login(string userid, string password)
        {
            return "TOEKN";
        }

        public void ClearToken()
        {
        }
    }
}