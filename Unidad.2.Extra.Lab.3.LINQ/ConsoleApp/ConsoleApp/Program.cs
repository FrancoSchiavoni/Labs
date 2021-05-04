using System;
using FuncionesLinqTests;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FuncionesLinqTest();
            
            f.ObtenerProvinciasQueEmpiezanConDetermindasLetrasTest();
            Console.WriteLine("Presione culquier tecla");
            Console.ReadKey();
            Console.Clear();
            
            f.ObtenerNumerosMayoresA20Test();
            Console.WriteLine("Presione culquier tecla");
            Console.ReadKey();
            Console.Clear();
            
            f.ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest();
            Console.WriteLine("Presione culquier tecla");
            Console.ReadKey();
            Console.Clear();

            f.AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest();
            Console.WriteLine("Presione culquier tecla");
            Console.ReadKey();


        }
    }
}
