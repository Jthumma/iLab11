namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces
{
    public interface ISsoLoginPortClientAdapter
    {
        string Login(string userid, string password);
        void ClearToken();
    }
}