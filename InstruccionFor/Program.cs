using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Instrucción for
             * Se divide en 3, declara una variable, una pregunta y una ejecucion o incremento.
             */

            int Nentero;
            Nentero = 0;

            Console.Write("ingrese un numero para definir la tabla de Multiplicar: ");
            Nentero= int.Parse(Console.ReadLine());

            for (int a=0; a<=12; a++)
            {
                Console.WriteLine(Nentero + " X " + a + " = "+ (Nentero * a));
            }
            Console.ReadKey();
        }
    }
}
