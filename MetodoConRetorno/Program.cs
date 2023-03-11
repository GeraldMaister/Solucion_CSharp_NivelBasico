using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo con Retorno de resultado
             * para devolver un resultado el tipo de static y el tipo de dato, 
             * ej:  static double CalcularTotal(double P1,int P2) porque va retornar un double.
             */
            string nombre;
            double pagoxdia;
            int dias;
            

            Console.Write("Ingresa tu Nombre: ");
            nombre= Console.ReadLine();

            Console.Write("Cuanto te pagan por dia trabajado? ");
            pagoxdia = double.Parse(Console.ReadLine());

            Console.Write("Cuantos dias trabajaste? ");
            dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por los dias de trabajo es: {0}", CalcularTotal(pagoxdia, dias));
            Console.ReadKey();
        }
        // metodo para obtener el total de dinero ganado por trabajo


        static double CalcularTotal(double P1,int P2)
        {
            

            double resultado;

            resultado = (P1 * P2);

            return resultado;
        }
    }
}
