using System;

namespace Profecion
{
    class Ingeniero : Profecion
    {
        public Ingeniero(string lastName)
        {
            this.name = "inge";
            this.lastName = lastName;
        }
        public override void dimeProfecion()
        {
            Console.WriteLine($"soy {this.name}");
        }
    }
}
