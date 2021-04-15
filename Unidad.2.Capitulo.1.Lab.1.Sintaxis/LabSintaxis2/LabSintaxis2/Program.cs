using System;
using System.Threading;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Value = "Ingrese un Texto";
            Console.WriteLine(Value);
            string inputText = Console.ReadLine();

            bool Resp = String.IsNullOrEmpty(inputText);

            if (Resp == true)
            {
                Console.WriteLine("Input Text please! bye");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Seleccione una Opción");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1 - UpperText");
                Console.WriteLine("2 - LowerText");
                Console.WriteLine("3 - LenText");

                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.Clear();

                if (opcion.Key == ConsoleKey.D1)
                { Console.WriteLine(inputText.ToUpper()); }

                if (opcion.Key == ConsoleKey.D2)
                { Console.WriteLine(inputText.ToLower()); }

                if (opcion.Key == ConsoleKey.D3)
                { Console.WriteLine("1) The length of '{0}' is {1}", inputText, inputText.Length); }

                if (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D3)
                { Console.WriteLine("No se eligio ninguna de las Opciones esperadas"); }


            }

            Thread.Sleep(2000);
            Console.Clear();


            Console.WriteLine("Repetimos con CASE");
            Console.WriteLine(Value);
            inputText = Console.ReadLine();

            Resp = String.IsNullOrEmpty(inputText);

            if (Resp)
            {
                Console.WriteLine("Input Text please! bye");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Seleccione una Opción");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1 - UpperText");
                Console.WriteLine("2 - LowerText");
                Console.WriteLine("3 - LenText");

                string caseSwitch = Console.ReadLine();


                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine(inputText.ToUpper());
                        break;
                    case "2":
                        Console.WriteLine(inputText.ToLower());
                        break;
                    case "3":
                        Console.WriteLine("1) The length of '{0}' is {1}", inputText, inputText.Length);
                        break;
                    default:
                        Console.WriteLine("No se eligio ninguna de las Opciones esperadas"); ;
                        break;
                }
            }
        }
    }
}