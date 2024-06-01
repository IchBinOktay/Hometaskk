using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class User
    {
        private string pin;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin
        {
            get { return pin; }
            set
            {

                if (value.CheckPin())
                {
                    pin = value;
                }
                else
                {
                    Console.WriteLine($"Error [ {Name}, PIN INCORRECT]");
                }
            }
        }
        public RegistrationMonth RegistrationMonth { get; set; }

        public User(string name, string surname, string pinn, RegistrationMonth registrationMonth)
        {
            Name = name;
            Surname = surname;
            Pin = pinn;
            RegistrationMonth = registrationMonth;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Surname} {Pin} {RegistrationMonth}");
            Console.WriteLine();

        }


    }
}
