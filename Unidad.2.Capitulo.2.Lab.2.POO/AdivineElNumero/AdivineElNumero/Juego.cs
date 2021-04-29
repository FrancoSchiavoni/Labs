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


            while (continuar)
            {

                Console.Clear();
                bool seguir = true;
                Console.WriteLine("Elija un numero maximo");
                int max = Convert.ToInt32(Console.ReadLine());
                Jugada j = new Jugada(max);


                while (seguir)
                {
                    Console.Clear();
                    Console.WriteLine("Elija un numero para adivinar");
                    int adivino = Convert.ToInt32(Console.ReadLine());
                    j.Comparar(adivino);
                    if (j.Adivino) 
                    {
                        seguir = false;
                        nresult.Add("Jugada" + _cjugadas , j.Intentos+1 ); 
                    } 

                }

                continuar = this.Continuar();
                _cjugadas += 1;

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



        private int PreguntarMaximo(Jugada j) { return j.Numero ; }
        private int PreguntarNumero(Jugada j) { return j.Numero; }



    }
}
