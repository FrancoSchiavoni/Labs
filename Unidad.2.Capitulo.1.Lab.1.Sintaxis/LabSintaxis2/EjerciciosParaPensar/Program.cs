using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosParaPensar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Suma de 2 numeros. 

            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma entre {num1} y {num2} es: {resultado}");

            // 2) Año bisiesto.
            Console.Clear();

            ConsoleKeyInfo kk;
            bool seguir = true;
            while (seguir)
            {
                string year = "0";
                int yearint;
                bool bisiesto = false;

                Console.WriteLine();
                Console.WriteLine("Ingrese un año: ");
                year = Console.ReadLine();
                yearint = Convert.ToInt32(year);

                if ((yearint % 4) == 0)
                {
                    if (yearint % 100 == 0)
                    {
                        if (yearint % 400 == 0) { bisiesto = true; }
                        else { bisiesto = false; }

                    }

                    else { bisiesto = false; };

                }
                else { bisiesto = false; }

                if (bisiesto) { Console.WriteLine("El año " + year + " es un año bisiesto"); }
                else { Console.WriteLine("El año " + year + " NO es un año bisiesto"); };

                do
                {
                    Console.WriteLine("Ingresa otro año?  (S/N)");
                    kk = Console.ReadKey();
                } while (kk.Key != ConsoleKey.S && kk.Key != ConsoleKey.N);

                Console.Clear();
                if (kk.Key == ConsoleKey.S) { seguir = true; } else { seguir = false; };
            }



            // 3) Fibonacci.
            Console.Clear();
            int x = 1, y = 0;
            int suma;
            Console.WriteLine("1");
            for (int contador = 0; contador < 12; contador++)
            {
                suma = x + y;
                Console.WriteLine(suma.ToString()) ;
                y = x;
                x = suma;
            }

        }
    }
}
