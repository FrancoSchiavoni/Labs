using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Per = new Clases.Personas("Franco", "Schiavoni", "21", "41636639");


            Console.WriteLine(Per.GetFullName());
            Console.WriteLine(Per.Edad);


        }
    }
}
