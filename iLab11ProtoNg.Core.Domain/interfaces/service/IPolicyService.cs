using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.models;

namespace iLab11ProtoNg.Core.Domain.interfaces.service
{
    public interface IPolicyService
    {
        List<PolicyModel> GetPolicies();
    }
}