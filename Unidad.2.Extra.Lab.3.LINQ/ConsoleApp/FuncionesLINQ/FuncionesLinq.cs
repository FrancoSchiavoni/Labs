using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {

            IEnumerable<string> numQuery =
            from p in provincias
            where p.Substring(0, 1) == "S" | p.Substring(0, 1) == "T"
            select p;

            return numQuery; 

        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            IEnumerable<int> numQuery =
            from n in numeros
            where n > 20
            select n;

            return numQuery;
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            IEnumerable<int> numQuery =
             from c in ciudades
             where c.Nombre.ToLower().StartsWith(ciudad.ToLower()) == true 
             select c.CodigoPostal;

            return numQuery;

        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IList<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {

            foreach ( Empleado e in empleadosParaAgregar)
            {
                
                empleados.Add(e) ;
                Console.WriteLine($"Agrego a  {e.Nombre}" );
            }

            IEnumerable<Empleado> numQuery;

            if (order == "ASC")
                { numQuery = empleados.OrderBy(empleado => empleado.Sueldo); }
            else
                { numQuery = empleados.OrderByDescending(empleado => empleado.Sueldo); } 
            
            return numQuery;
        }
    }
}
