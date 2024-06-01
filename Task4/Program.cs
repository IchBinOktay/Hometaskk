using Task4;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(2006, 08, 04);
        int age = birthDate.GetAge();

        Console.WriteLine($"Doğum tarihi: {birthDate.ToShortDateString()}, Yaş: {age}");
    }
}