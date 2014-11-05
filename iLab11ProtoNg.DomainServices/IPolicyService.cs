using System.Collections.Generic;
using iLab11ProtoNg.Models;

namespace iLab11ProtoNg.DomainServices
{
    public interface IPolicyService
    {
        List<PolicyModel> GetPolicies();
    }
}