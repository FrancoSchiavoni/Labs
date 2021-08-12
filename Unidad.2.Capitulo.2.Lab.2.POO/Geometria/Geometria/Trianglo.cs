using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Trianglo
    {

        private int lado1;
        private int lado2;
        private int lado3;

        public int Lado1
        {
            get => lado1;
            set
            {
                lado1 = Lado1;
            }
        }

        public int Lado2
        {
            get => lado2;
            set
            {
                lado2 = Lado2;
            }
        }

        public int Lado3
        {
            get => lado3;
            set
            {
                lado3 = Lado3;
            }
        }

        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();

        }
    }
}