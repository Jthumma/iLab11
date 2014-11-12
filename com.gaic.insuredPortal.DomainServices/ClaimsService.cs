using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class ClaimsService : IClaimsService
    {
        public List<ClaimsModel> GetClaims(UserModel user)
        {
            var claims = new List<ClaimsModel>();

            #region BackOffice Claims

            if (user.Roles.Contains(RoleItemModel.BackOffice))
            {
                claims.Add(new ClaimsModel
                {
                    ClaimId = 4,
                    ClaimNumber = "564581455",
                    LossDesc = "EE broke tooth on chicken nugget",
                    Status = "Closed",
                    LossDate = "09/15/2012",
                    ReportDate = "09/17/2012",
                    Adjuster = "Stephanie Magee",
                    Claimant = "Elizabeth Clement",
                    CloseDate = "11/13/2012"
                });
                claims.Add(new ClaimsModel
                {
                    ClaimId = 3,
                    ClaimNumber = "564577466",
                    LossDesc = "Sprain ankle",
                    Status = "Closed",
                    LossDate = "06/25/2012",
                    ReportDate = "06/25/2012",
                    Adjuster = "Stephanie Magee",
                    Claimant = "Kliner Tomarra",
                    CloseDate = "12/27/2012"
                });
                claims.Add(new ClaimsModel
                {
                    ClaimId = 2,
                    ClaimNumber = "564617167",
                    LossDesc = "Finger laceration cleaning counter and cut finger on knife",
                    Status = "Open",
                    LossDate = "10/08/2014",
                    ReportDate = "10/27/2014",
                    Adjuster = "Heather Cooper",
                    Claimant = "Claudia Reedy"
                });
                claims.Add(new ClaimsModel
                {
                    ClaimId = 1,
                    ClaimNumber = "564577476",
                    LossDesc = "Right ankle sprain. EE was carrying a laundry basket",
                    Status = "Closed",
                    Adjuster = "Malia Gill",
                    Claimant = "Barbee Ruth",
                    LossDate = "06/11/2012",
                    ReportDate = "06/12/2012",
                    CloseDate = "08/16/2012"
                });


            }

            #endregion

            #region Insured Claims

            if (user.Roles.Contains(RoleItemModel.Insured))
            {
                claims.Add(new ClaimsModel
                {
                    ClaimId = 1,
                    ClaimNumber = "3372255",
                    LossDesc = "Construction sign blew out of stand and hit truck",
                    Status = "Open",
                    LossDate = "06/16/2014",
                    ReportDate = "06/17/2014",
                    Claimant = "Dirk Olsen",

                });
            }
            #endregion

            return claims;
        }
    }
}