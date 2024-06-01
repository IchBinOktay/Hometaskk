using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static int FahrenheitToCelsius(int fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
