using System;

namespace Clases
{
    public class A
    {
        string _nombreInstancia;

        public A() { _nombreInstancia = "Instancia sin nombre"; }

        public A(string nombreInstancia) { _nombreInstancia = nombreInstancia; }

        public void MostrarNombre() { Console.WriteLine(_nombreInstancia); }
        public void M1() { Console.WriteLine("El metodo M1 fue invocado"); }
        public void M2() { Console.WriteLine("El metodo M2 fue invocado"); }
        public void M3() { Console.WriteLine("El metodo M3 fue invocado"); }



    }
}
