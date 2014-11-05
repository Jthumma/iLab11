using System.Collections.Generic;
using iLab11ProtoNg.Models;

namespace iLab11ProtoNg.DomainServices
{
    public interface IClaimsService
    {
        List<ClaimsModel> GetClaims();
    }
}