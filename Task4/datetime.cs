using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class DataTimeExtansion
    {
        public static int GetAge(this DateTime birthDate)
        {
            int today = DateTime.Today.Year;
            int age = today - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age))
                age--;

            return age;

        }
    }
}
