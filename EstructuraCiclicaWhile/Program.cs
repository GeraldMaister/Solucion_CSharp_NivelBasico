using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCiclicaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Estructuca Ciclica While
          * Primero se pregunta y luego ejecuta.
          */
            int Correlativo;
            Correlativo = 0;

            Console.WriteLine("La tabla #5");

            while(Correlativo<=12) 
            { 
                Console.WriteLine("5 x " + Correlativo + " = " + (5*Correlativo));
                Correlativo++;
            }
            Console.ReadKey();

        }
    }
}
