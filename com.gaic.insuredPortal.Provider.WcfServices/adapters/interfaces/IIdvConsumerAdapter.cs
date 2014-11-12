namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces
{
    public interface IIdvConsumerAdapter
    {
        void Authenticate(string vid, string password, string token);
        bool Ping(string token);
    }
}