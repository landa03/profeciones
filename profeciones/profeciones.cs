using System;

namespace Profecion
{
    class Doctor : Profecion
    {
        public Doctor(string lastName)
        {
            this.name = "doctor";
            this.lastName = lastName;
        }
        public override void dimeProfecion()
        {
            Console.WriteLine($"soy {this.name}");
        }
    }
}
