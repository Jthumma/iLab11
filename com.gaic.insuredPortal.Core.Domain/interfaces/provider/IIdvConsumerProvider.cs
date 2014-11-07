namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IIdvConsumerProvider
    {
        bool Ping(string token);
    }
}