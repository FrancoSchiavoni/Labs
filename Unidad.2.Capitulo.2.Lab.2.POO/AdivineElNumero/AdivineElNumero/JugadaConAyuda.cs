using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        public new void Comparar(int numero)
        {

            if (numero != Numero)
            {
                Intentos += 1;
                Console.WriteLine("No le pegaste negrito");
                int diferencia = Math.Abs(numero - Numero);
                if (diferencia > Numero * 0.5)
                     Console.WriteLine("Estás bastante lejos"); 
                else if (diferencia > Numero * 0.25)
                    Console.WriteLine("Estas lejos");
                else if (diferencia > Numero * 0.1)
                    Console.WriteLine("Estar cerca!");
                else
                    Console.WriteLine("Estas bastante cerca!");


                Console.ReadKey();
                Adivino = false;
            }
            else
            {
                Console.WriteLine("Ganaste negrazo");
                Adivino = true;
            }




        }


    }
}
