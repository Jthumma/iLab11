using System.ServiceModel;

namespace com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces
{
    public interface IWcfEndpointAddressAdapter
    {
        EndpointAddress EndpointAddress { get; set; }
    }
}