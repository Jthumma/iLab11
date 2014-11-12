using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeIdvConsumerAdapter : IIdvConsumerAdapter
    {
        public void Authenticate(string vid, string password, string token)
        {
        }

        public bool Ping(string token)
        {
            return true;
        }

        public void Authenticate(string vid, string password)
        {
        }
    }
}