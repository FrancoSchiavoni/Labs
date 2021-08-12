using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B:A
    {
        public B() : base("Instacia de B") { }

        public void M4() { Console.WriteLine("Metodo del hijo Invocado"); }
    }
}
