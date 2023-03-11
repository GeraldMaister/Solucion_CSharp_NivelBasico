using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodos con parametros
             * el parametro es lo que va en el parentesis que esta esperando un dato para poder proceden con el metodo.
             * 
             
             */

            string OperacionMatematica;
            int nOperacion;

            Console.Write("Quieres realizar la tabla de Sumar o Multiplicar? " );
            OperacionMatematica = Console.ReadLine();

            Console.Write("Que numero de tabla desea que se muestre? ");
            nOperacion = int.Parse(Console.ReadLine());

            if(OperacionMatematica == "Sumar" ) 
            {
                Sumar(nOperacion);
            }
            else if (OperacionMatematica == "Multiplicar")
            {
                Multiplicar(nOperacion);
            }
             else
            {
                Console.WriteLine("Operacion matematica no valida");
            }


            Console.ReadKey();
        }
        // metodo de la tabla de Sumar
          static void Sumar(int Numero) 
          { 
            for(int a = 1; a<=12; a++)
            {
                Console.WriteLine("{0} + {1} = {2}", Numero, a, (Numero+a));
            }

        
          }

        //Método de la tabla de multiplicar
        static void Multiplicar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine("{0} X {1} = {2}", Numero, a, (Numero * a));
            }


        }
    }
}
