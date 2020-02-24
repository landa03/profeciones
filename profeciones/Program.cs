using System;

namespace Profecion
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor("Juan");
            doc.dimeProfecion();
            Console.WriteLine(doc.fullName());
            doc.LastName = "Peres";
            Console.WriteLine(doc.LastName);
            Console.WriteLine(doc.fullName());
            
            Ingeniero inge = new Ingeniero("jony");
            inge.dimeProfecion();
            Console.WriteLine(inge.fullName());
            inge.LastName = "joney";
            Console.WriteLine(inge.LastName);
            Console.WriteLine(inge.fullName());
           
        }
    }
}
