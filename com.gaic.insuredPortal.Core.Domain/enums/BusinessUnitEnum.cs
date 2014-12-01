using System.ComponentModel;

namespace com.gaic.insuredPortal.Core.Domain.enums
{
    public enum BusinessUnitEnum
    {
        [Description("Trucking")] Trucking,
        [Description("StrategicComp")] StrategicComp
    }

    public enum PolicyStatusEnum
    {
        [Description("Cancelled")]
        Cancelled,
        [Description("New Business")]
        NewBusiness
    }
}