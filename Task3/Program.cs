using Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Celsius:");
        int celsius = Convert.ToInt32(Console.ReadLine());
        int fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius}C in Fahrenheit: {fahrenheit}");
        Console.WriteLine("Fahrenheit:");
        int fahrenheitInput = Convert.ToInt32(Console.ReadLine());
        int celsiusOutput = TemperatureConverter.FahrenheitToCelsius(fahrenheitInput);
        Console.WriteLine($"{fahrenheitInput}F in Celsius: {celsiusOutput}");
    }
}