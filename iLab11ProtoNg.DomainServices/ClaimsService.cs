using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.interfaces.service;
using iLab11ProtoNg.Core.Domain.models;

namespace iLab11ProtoNg.DomainServices
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