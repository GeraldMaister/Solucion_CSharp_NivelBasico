using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCiclicaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        { /* Estructura ciclica de Do While
           * Quiere decir haz tal cosa mientras pase esto.
           * Primero ejecuta el primer proceso y luego evalua con el while.
           * Numero++: sirve para incrementar 1 al int.
           */

            int Numero;

            Numero = 0;

            do
            {
                Console.WriteLine("El valor de la variable Numero es: " + Numero);
                Numero++;
            } while (Numero<=10);
            Console.ReadKey();
        }
    }
}
