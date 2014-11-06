using System.Collections;
using System.Collections.Generic;

namespace iLab11ProtoNg.Core.Domain
{
    public static class Utils
    {
        public static bool HasRows(ICollection list)
        {
            return (list != null) && (list.Count != 0);
        }

        public static bool HasRows<T>(ICollection<T> list)
        {
            return (list != null) && (list.Count != 0);
        }
    }
}