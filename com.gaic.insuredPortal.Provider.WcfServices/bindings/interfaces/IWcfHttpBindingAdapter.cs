using System.ServiceModel;

namespace com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces
{
    public interface IWcfHttpBindingAdapter
    {
        BasicHttpBinding Binding { get; set; }
    }
}