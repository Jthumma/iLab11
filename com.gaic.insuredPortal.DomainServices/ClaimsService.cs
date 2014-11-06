using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class ClaimsService : IClaimsService
    {
        public List<ClaimsModel> GetClaims()
        {
            var claims = new List<ClaimsModel>
            {
                new ClaimsModel {ClaimId = 1, ClaimDesc = "first claim"},
                new ClaimsModel {ClaimId = 2, ClaimDesc = "Second claim"}
            };
            return claims;
        }
    }
}