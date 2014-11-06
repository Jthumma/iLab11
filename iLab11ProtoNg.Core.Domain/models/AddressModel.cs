using System;

namespace iLab11ProtoNg.Core.Domain.models
{
    public class AddressModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Zip4 { get; set; }

        public string Display { get { return String.Format("{0} {1}", FirstLine, LastLine).Trim(); } }

        private string FirstLine
        {
            get
            {
                return String.Format("{0} {1}",
                    String.IsNullOrEmpty(Line1) ? String.Empty : Line1,
                    String.IsNullOrEmpty(Line2) ? String.Empty : Line2).Trim();
            }
        }

        private string LastLine
        {
            get
            {
                return String.Format("{0}, {1} {2}",
                    String.IsNullOrEmpty(City) ? String.Empty : City,
                    String.IsNullOrEmpty(State) ? String.Empty : State,
                    ZipPlusFour).Trim();
            }
        }

        private string ZipPlusFour
        {
            get
            {
                return String.IsNullOrEmpty(Zip4)
                    ? String.IsNullOrEmpty(Zip) ? String.Empty : Zip
                    : String.Format("{0}-{1}", String.IsNullOrEmpty(Zip) ? String.Empty : Zip, String.IsNullOrEmpty(Zip4) ? String.Empty : Zip4).Trim();
            }
        }
    }
}