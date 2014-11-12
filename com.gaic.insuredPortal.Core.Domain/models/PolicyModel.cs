using System;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class PolicyModel
    {
        public int PolicyId { get; set; }
        public string Number { get; set; }
        public string Product { get; set; }

        public string Symbol
        {
            get { return String.Format("{0} {1} {2}{3}", Product, Number, Mod, Version); }
        }

        public int Mod { get; set; }
        public int Version { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Status { get; set; }
        public AgentModel Agent { get; set; }
        public InsuredModel Insured { get; set; }

        public bool IsSubPolicy
        {
            get { return !String.IsNullOrEmpty(MasterPolicyNumber); }
        }

        //public PolicyModel MasterPolicy { get; set; }
        public string PolicyHolderName { get; set; }
        public string MasterPolicyNumber { get; set; }
    }
}