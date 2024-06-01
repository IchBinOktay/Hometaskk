
using Task5;

public static class Program
{
    public static void Main()
    {
        Car toyota = new Car("prius", "prime");
        Motocycle motor = new Motocycle(" ducati", 2020);
        Bus bus = new Bus("85", 90);

        toyota.Start();
        bus.Start();
        motor.GetDetails();
        bus.Stop();
        toyota.Stop();

    }
}