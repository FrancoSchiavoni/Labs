using System;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] Arreglo = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.Write($"Ingrese valor para la posición {i}: ");
                Arreglo[i] = Console.ReadLine();
            }
            for (int i = 0; i < cantIteraciones; i++)
            {
                int posicion = cantIteraciones - i;
                Console.Write($"El valor de la posición {posicion} es: ");
                Console.WriteLine(Arreglo[posicion - 1]);
            }
        }
    }
}
