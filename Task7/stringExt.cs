using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{

    internal static class stringExt
    {
        public static bool CheckPin(this string pin)
        {
            if (pin != null && pin.Length == 7 && pin.ToUpper() == pin)
            {
                return true;

            }
            return false;
        }
    }
}
