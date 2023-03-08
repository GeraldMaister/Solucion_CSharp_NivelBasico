using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Matrices
             * Es una estructura de datos que permite amanecerar un conjunto de datos del mismo tipo
               a travez de columnas y filas.
             * Primero el tipo de variable [] Nombre = new tipo de variable [filas,columnas];
             * Tener en cuenta que 3 filas y 2 columnas, empieza desde 0, ej: [3,2] seria [0,1,2/0,1] 5 espacios
             * for (int i = 0; i<Persona.GetLength(0); i++) getlength(0) y (1),
               quiere decir dime el tamaño de la dimension de la matriz  donde 0 es fila y 1 es para columna.
             
            string[,] Persona = new string[4, 2];


            Persona[0, 0] = "Victor";
            Persona[0, 1] = "Ramos";

            Persona[1, 0] = "Carlos";
            Persona[1, 1] = "Ramirez";

            Persona[2, 0] = "Ana";
            Persona[2, 1] = "Arias";

            Persona[3, 0] = "Ruben ";
            Persona[3, 1] = "Osoria";

            /* for (int i = 0; i<Persona.GetLength(0); i++)
              {
                 Console.WriteLine("Mi nombre es : " + Persona[i,0]+ " y mi apellido: " + Persona[i, 1]);



              }

             Console.ReadKey();
            

            int i = 0;
            do
            {
                Console.WriteLine("Mi nombre es : " + Persona[i, 0] + " y mi apellido: " + Persona[i, 1]);
                i++;
            } while (i < Persona.GetLength(0));
            Console.ReadKey();
            */







            // Console.WriteLine("El valor de la matriz persona [0,0] es: " + Persona[3,2]);

            string[,] Persona = {
    {"Victor", "Ramos"},
    {"Carlos", "Ramirez"},
    {"Ana", "Arias"},
    {"Ruben", "Osoria"}
};

            foreach (string nombre in Persona)
            {
                Console.WriteLine("Mi nombre es : " + nombre[0] + " y mi apellido: " + nombre[1]);
            }

            Console.ReadKey();

        }
    }
}
