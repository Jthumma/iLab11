using System;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class ClaimsModel
    {
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public string LossDesc { get; set; }
        public string LossDate { get; set; }
        public string ReportDate { get; set; }
        public string Status { get; set; }
        public string CloseDate { get; set; }
        public string Adjuster { get; set; }
        public string Claimant { get; set; }
    }
}