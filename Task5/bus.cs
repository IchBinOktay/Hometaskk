using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Bus
    {
        public string Name { get; set; }
        public int Passenger { get; set; }

        public Bus(string name, int passenger)
        {
            Name = name;
            Passenger = passenger;
        }


        public void Start()
        {
            Console.WriteLine("Bus started");
        }
        public void Stop()
        {
            Console.WriteLine("Bus stopped");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Bus : Name: {Name},Passenger {Passenger}");
        }
    }
}
