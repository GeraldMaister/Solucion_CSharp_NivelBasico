using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Vectores
             * Nos permite almacenar informacion en conjunto a travez de posiciones.
             * Comienza las posiciones desde 0, el cual seria victor.
             * Nombres[2]: para seleccionar la posicion de la info del vector para llamar.
             * Nombres.Length: Para saber la cantidad de contenido que tiene el nector.
             */

            string[] Nombres = { "VICTOR", "CARLOS", "ANA", "LUIS", "JORGE" };
            //Console.WriteLine("El nombre del vector en el indice 2 es: " + Nombres[2]);
           // Console.WriteLine("La cantidad de elementos que tiene tu vector es: " + Nombres.Length);
           for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("Contenido del Vector Nombres en el indice " + i + " es: " + Nombres[i]);
            }
            Console.ReadKey();
;        }  
        
        
    }
}
