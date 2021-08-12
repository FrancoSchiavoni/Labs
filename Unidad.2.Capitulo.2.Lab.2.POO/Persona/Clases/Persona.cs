using System;

namespace Clases
{
    public class Personas
    {

        public Personas(string n, string a, string e, string d) 
        {
                Nombre = n;
                Apellido = a;
                Edad = e;
                DNI = d;

            Console.WriteLine($"Se creo la instancia de la persona con DNI = {DNI}: ");
                
        }

        ~Personas()
        {
            System.Diagnostics.Trace.WriteLine("Se destruyo la instancia ");
        }

        private string _nombre;
        private string _apellido;
        private string _edad;
        private string _dni;

        public string Nombre 
        {
            get  => _nombre; 
            set  =>  _nombre =  value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public string Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public string DNI
        {
            get => _dni;
            set => _dni = value;
        }


        public string GetFullName() 
        { return (String.Concat(Nombre," ", Apellido));}



    }
}
