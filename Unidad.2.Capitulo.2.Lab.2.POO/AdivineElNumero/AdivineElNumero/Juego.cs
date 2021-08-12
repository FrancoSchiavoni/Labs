using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AdivineElNumero
{
    public class Juego
    {

        //Atributos
        public int _record;
        Hashtable nresult = new Hashtable();
        int _cjugadas = 1;

        //Metodos
        public void ComenzarJuego()
        {
            Console.WriteLine("Bienvenido al Juego. Presione cualquier tecla");
            Console.ReadKey();
            bool continuar = true;
            ConsoleKeyInfo cc;

            while (continuar)
            {
                bool menu = true;
                Console.Clear();
                string ayuda;
                do
                {
                    Console.WriteLine("¿Desea jugar con ayuda (s/n)?");
                    ayuda = (Console.ReadLine());
                }

                while (ayuda != "s" && ayuda != "n");

                if (ayuda == "n")
                {
                    Console.WriteLine("Elija un numero maximo");
                    int max = Convert.ToInt32(Console.ReadLine());
                    Jugada j = new Jugada(max);



                    while (menu)
                    {
                        bool seguir = true;
                        int caseSwitch;
                        Console.Clear();
                        Console.WriteLine("1 - Jugar");
                        Console.WriteLine("2 - Consultar Maximo");
                        Console.WriteLine("3 - Consultar Numero");
                        Console.WriteLine("4 - Salir de esta jugada");
                        do
                        {
                            Console.WriteLine("Elija que deseaa hacer");
                            caseSwitch = Convert.ToInt32(Console.ReadLine());
                        }

                        while (caseSwitch != 1 && caseSwitch != 2 && caseSwitch != 3 && caseSwitch != 4);

                        switch (caseSwitch)
                        {
                            case 1:
                                if (j.Adivino == false)
                                {
                                    while (seguir)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Elija un numero para adivinar");
                                        int adivino = Convert.ToInt32(Console.ReadLine());
                                        j.Comparar(adivino);
                                        if (j.Adivino)
                                        {
                                            seguir = false;
                                            nresult.Add("Jugada " + _cjugadas, j.Intentos + 1);
                                        }

                                    }
                                    _cjugadas += 1;

                                    do
                                    {
                                        Console.WriteLine("Deseea volver al menu?  (S/N)");
                                        cc = Console.ReadKey();
                                    }

                                    while (cc.Key != ConsoleKey.S && cc.Key != ConsoleKey.N);

                                    if (cc.Key == ConsoleKey.S) { menu = true; } else { menu = false; };
                                }
                                else { Console.WriteLine("Ya ganaste esta jugada"); }

                                break;

                            case 2:

                                int maxi = PreguntarMaximo(j);
                                Console.WriteLine("El numero maximo es " + maxi);
                                do
                                {
                                    Console.WriteLine("Deseea volver al menu?  (S/N)");
                                    cc = Console.ReadKey();
                                }

                                while (cc.Key != ConsoleKey.S && cc.Key != ConsoleKey.N);

                                if (cc.Key == ConsoleKey.S) { menu = true; } else { menu = false; };

                                break;

                            case 3:
                                int num = PreguntarNumero(j);
                                Console.WriteLine("El numero es " + num);

                                do
                                {
                                    Console.WriteLine("Deseea volver al menu?  (S/N)");
                                    cc = Console.ReadKey();
                                }

                                while (cc.Key != ConsoleKey.S && cc.Key != ConsoleKey.N);

                                if (cc.Key == ConsoleKey.S) { menu = true; } else { menu = false; };

                                break;
                            default:
                                Console.WriteLine("Chau");
                                menu = false;
                                break;


                        }
                    }

                    continuar = this.Continuar();
                }
                else  {


                    Console.WriteLine("Elija un numero maximo");
                    int max = Convert.ToInt32(Console.ReadLine());
                    JugadaConAyuda j = new JugadaConAyuda(max);

                    while (menu)
                    {
                        bool seguir = true;
                        int caseSwitch;
                        Console.Clear();
                        Console.WriteLine("1 - Jugar");
                        Console.WriteLine("2 - Consultar Maximo");
                        Console.WriteLine("3 - Consultar Numero");
                        Console.WriteLine("4 - Salir de esta jugada");
                        do
                        {
                            Console.WriteLine("Elija que deseaa hacer");
                            caseSwitch = Convert.ToInt32(Console.ReadLine());
                        }

                        while (caseSwitch != 1 && caseSwitch != 2 && caseSwitch != 3 && caseSwitch != 4);

                        switch (caseSwitch)
                        {
                            case 1:
                                if (j.Adivino == false)
                                {
                                    while (seguir)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Elija un numero para adivinar");
                                        int adivino = Convert.ToInt32(Console.ReadLine());
                                        j.Comparar(adivino);
                                        if (j.Adivino)
                                        {
                                            seguir = false;
                                            nresult.Add("Jugada " + _cjugadas, j.Intentos + 1);
                                        }

                                    }
                                    _cjugadas += 1;

                                    do
                                    {
                                        Console.WriteLine("Deseea volver al menu?  (S/N)");
                                        cc = Console.ReadKey();
                                    }

                                    while (cc.Key != ConsoleKey.S && cc.Key != ConsoleKey.N);

                                    if (cc.Key == ConsoleKey.S) { menu = true; } else { menu = false; };
                                }
                                else { Console.WriteLine("Ya ganaste esta jugada"); }

                                break;

                            case 2:

                                int maxi = PreguntarMaximo(j);
                                Console.WriteLine("El numero maximo es " + maxi);
                                do
                                {
                                    Console.WriteLine("Deseea volver al menu?  (S/N)");
                                    cc = Console.ReadKey();
                                }

                                while (cc.Key != ConsoleKey.S && cc.Key != ConsoleKey.N);

                                if (cc.Key == ConsoleKey.S) { menu = true; } else { menu = false; };

                                break;

                            case 3:
                                int num = PreguntarNumero(j);
                                Console.WriteLine("El numero es " + num);

                                do
                                {
                                    Console.WriteLine("Deseea volver al menu?  (S/N)");
                                    cc = Console.ReadKey();
                                }

                                while (cc.Key != ConsoleKey.S && cc.Key != ConsoleKey.N);

                                if (cc.Key == ConsoleKey.S) { menu = true; } else { menu = false; };

                                break;
                            default:
                                Console.WriteLine("Chau");
                                menu = false;
                                break;


                        }
                    }

                    continuar = this.Continuar();
                }



            }

            this.CompararRecord();


        }




        private void CompararRecord() 
        {
            Console.Clear();
            foreach (DictionaryEntry elemento in nresult)
            { Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value); }
        }
        
        
        private bool Continuar() 
        {
            ConsoleKeyInfo kk;
            bool seguir = false;
            do
            {
              Console.WriteLine("Deseea jugar denuevo?  (S/N)");
              kk = Console.ReadKey();
            } 

            while (kk.Key != ConsoleKey.S && kk.Key != ConsoleKey.N);

            if (kk.Key == ConsoleKey.S) { seguir = true; } else { seguir = false; };
            return seguir; 
        }


        private int PreguntarMaximo(Jugada j) { return j.Maximo ; }
        private int PreguntarNumero(Jugada j) { return j.Numero; }



    }
}
