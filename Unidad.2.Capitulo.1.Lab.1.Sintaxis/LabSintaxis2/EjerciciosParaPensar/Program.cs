using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

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
            System.Threading.Thread.Sleep(1000);


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
                Console.WriteLine(suma.ToString());
                y = x;
                x = suma;
            }

            //4) Numeros Pares del 1 al 100 
            Console.Clear();
            x = 0;
            for (int c = 0; x < 100; c++)
            {
                x = x + 2;
                Console.WriteLine(x.ToString());
            }

            Thread.Sleep(1000);

            // 5) Funcion que devuelve el numero del mes

            Console.Clear();

            int NumeroMes(string mes)
            {

                string[] paises = { "Enero", "Febrero", "Marzo", "Abril", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Nomviembre", "Diciembre" };

                for (int i = 0; i <= 12; i++)
                {
                    if (mes == paises[i])
                    {
                        return (i + 1);
                    }
                }
                return 0;


            }

            int numero = NumeroMes("Abril");

            if (numero == 0)
            {
                Console.WriteLine("No se encontro el mes solicitado");
            }
            else
            {

                Console.WriteLine(numero.ToString()); ;
            }


            // 6) Dado un número entero, que se convierta a número romano.

            Console.Clear();
            static string ToRoman(int number)
            {
                if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("INGRESA UN VALOR ENTRE 1 Y 3999");
                if (number < 1) return string.Empty;
                if (number >= 1000) return "M" + ToRoman(number - 1000);
                if (number >= 900) return "CM" + ToRoman(number - 900);
                if (number >= 500) return "D" + ToRoman(number - 500);
                if (number >= 400) return "CD" + ToRoman(number - 400);
                if (number >= 100) return "c" + ToRoman(number - 100);
                if (number >= 90) return "XC" + ToRoman(number - 90); if (number >= 50) return "L" + ToRoman(number - 50);
                if (number >= 40) return "XL" + ToRoman(number - 40); if (number >= 10) return "X" + ToRoman(number - 10);
                if (number >= 9) return "IX" + ToRoman(number - 9); if (number >= 5) return "V" + ToRoman(number - 5);
                if (number >= 4) return "IV" + ToRoman(number - 4); if (number >= 1) return "I" + ToRoman(number - 1);
                throw new ArgumentOutOfRangeException("F"); 
            };

            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine(ToRoman(numero));
            Thread.Sleep(10000);



            // 7) Calcular los N primeros números primos gemelos.

            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de numeros primos gemelos que desee: ");
            numero = Convert.ToInt32((Console.ReadLine()));

            int gemelo = 0;
            int n = 2;
            int total = 1;
            while (total <= numero)
            {
                bool esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                if (esPrimo)
                {
                    gemelo = n;
                    if (n == (gemelo - 2))
                        { Console.WriteLine(n); }
                    total++;
                }
                
                n++;
            }



        }
    }
}
