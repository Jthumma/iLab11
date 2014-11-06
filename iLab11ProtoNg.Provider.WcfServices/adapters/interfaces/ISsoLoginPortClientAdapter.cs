namespace iLab11ProtoNg.Provider.WcfServices.adapters.interfaces
{
    public interface ISsoLoginPortClientAdapter
    {
        string Login(string userid, string password);
        void ClearToken();
    }
}