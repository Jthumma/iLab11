using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.service
{
    public interface IClaimsService
    {
        List<ClaimsModel> GetClaims(UserModel user);
    }
}