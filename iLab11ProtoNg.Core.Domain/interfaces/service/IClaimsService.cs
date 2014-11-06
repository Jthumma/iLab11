using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.models;

namespace iLab11ProtoNg.Core.Domain.interfaces.service
{
    public interface IClaimsService
    {
        List<ClaimsModel> GetClaims();
    }
}