using System.ServiceModel;

namespace iLab11ProtoNg.Provider.WcfServices.bindings.interfaces
{
    public interface IWcfHttpBindingAdapter
    {
        BasicHttpBinding Binding { get; set; }
    }
}