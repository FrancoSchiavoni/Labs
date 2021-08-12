using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    public class Jugada
    {
        // Contrusctor
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _numero = rnd.Next(maxNumero);
            this.Maximo = maxNumero;
        }

        ~Jugada() { }

        //Atributos
        int _maximo;
        int _numero;
        int _intentos = 0;
        bool _adivino = false; 

        //Propiedades
        public int Intentos { get => _intentos; set => _intentos = value; }
        public bool Adivino { get => _adivino; set => _adivino = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public int Maximo { get => _maximo; set => _maximo = value; }


        //Metodos
        public void Comparar(int numero)
        { 
            if (numero != Numero)
            {
                Intentos += 1;
                Console.WriteLine("No le pegaste ");
                Console.ReadKey();
                Adivino = false;
            }
            else 
            {
                Console.WriteLine("Ganaste ");
                Adivino = true;
            }
                
        
        }
        
    
    }
}
