using System.ServiceModel;

namespace iLab11ProtoNg.Provider.WcfServices.bindings.interfaces
{
    public interface IWcfEndpointAddressAdapter
    {
        EndpointAddress EndpointAddress { get; set; }
    }
}