using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodos ejemplo 1
             * static void variable() 
             {
                   string nombre;
                   Console.Write("Ingresa tu nombre ");
                   nombre = Console.ReadLine();

                   Console.WriteLine("Tu nombre es: {0} ", nombre);
            

             } este es el metodo secundario creado
             * para llamarlo es el nombre del metodo y parentesis y ; asi: IngresoDatos(); y este va ejecutar
               todo lo que tenga dentro.
             */
            IngresoDatos();
            Console.ReadKey();

        }
        static void IngresoDatos()
        {
            //Metodo ejemplo 1
            string nombre;
            Console.Write("Ingresa tu nombre ");
            nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: {0} ", nombre);     
        }
    }
}
 