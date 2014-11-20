namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IProducerProvider
    {
        bool Ping(string token);
    }
}