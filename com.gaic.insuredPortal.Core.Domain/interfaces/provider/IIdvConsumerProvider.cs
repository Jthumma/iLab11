namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IIdvConsumerProvider
    {
        void Authenticate(string vid, string password, string token);
        bool Ping(string token);
    }
}