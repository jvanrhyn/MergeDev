using System;
using System.Linq;

namespace MergeDev
{
    public static class Core
    {
        public static string DoReverse(this string value)
        {
            // As ar as code goes, this is pointless
            // but we are testing github actions here.
            return value.Reverse().ToString();
        }
    }
}
