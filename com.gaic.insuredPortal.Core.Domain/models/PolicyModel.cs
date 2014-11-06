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
        public string EffDate { get; set; }
    }
}