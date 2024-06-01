using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Car : IVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name}, {Color}");
        }

        public void Start()
        {
            Console.WriteLine("Car Started");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped");
        }
    }
}
