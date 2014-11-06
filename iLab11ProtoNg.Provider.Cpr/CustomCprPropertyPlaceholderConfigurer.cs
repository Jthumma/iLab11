using System;
using Utility.CPR;

namespace iLab11ProtoNg.Provider.Cpr
{
    public class CustomCprPropertyPlaceholderConfigurer : CPRPropertyPlaceholderConfigurer
    {
        private string _namespace;

        // A wrapper property to the base write only cprNamespace property
        public string Namespace
        {
            set
            {
                _namespace = value;

                //this is important.
                cprNamespace = value;
            }
            get
            {
                if (String.IsNullOrEmpty(_namespace)) return _namespace;

                if (_namespace.Substring(_namespace.Length - 1, 1) != ".")
                {
                    _namespace = _namespace + ".";
                }
                return _namespace;
            }
        }
    }
}