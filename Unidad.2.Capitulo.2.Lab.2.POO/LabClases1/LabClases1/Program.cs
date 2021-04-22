using System;
using Clases;
namespace LabClases1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new A();
            var b = new B();
            var a2 = new A("Franco Schiavoni");

            Console.WriteLine("Metodos de A");
            a.MostrarNombre();
            a.M1();
            a.M2();
            a.M3();
            Console.WriteLine("------------------------");
            Console.WriteLine("Metodos de B");
            b.MostrarNombre();
            b.M1();
            b.M2();
            b.M3();
            b.M4();
            Console.WriteLine("------------------------");
            Console.WriteLine("Metodos de A variante");
            a2.MostrarNombre();
            

        }
    }
}
