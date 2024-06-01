using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal static class stringExt
    {
        public static bool CheckPolindrome(this string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (reversed == word)
            {
                return true;
            }
            return false;
        }
    }
}
