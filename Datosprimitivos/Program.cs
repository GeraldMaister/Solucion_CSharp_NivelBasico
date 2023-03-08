using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datosprimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* tipos de variables
             * dar valor a las variables
             * aritmetica %: sirve para cuando haga una division me de el residuo, lo que sobro
             * console.writeline: para escribir en consola con . y aparte.
             * console.write: para escribir en consola con . y seguido.
             * edad = Convert.ToInt32(Console.ReadLine()); para leer lo que escriben en consola y conver para modificar dato
             * Console.ReadKey(); para finalizar esa parte en la consola
             * Const int Edad=2500; sirve para poner un valor a una variable que no cambia desde su creacion.
             * Dynamic variable: sirve para crear una variable que esta a la espera de un valor para determinar su tipo
               de variable que sera.
             *
             
             ------------------------------------------------------------------------------------------------------
             WriteLine y Write solo

            int edad;
            string nombre = "gerald";
            double sueldo;
            bool casado;
            edad = 39;
            sueldo= 29000;
            casado = false;

            Console.WriteLine("Mi nombre es: " + nombre);
            Console.WriteLine("Mi edad es: " + edad);
            Console.WriteLine("Mi sueldo es de: " + sueldo);
            Console.WriteLine("Estas casado: " + casado);
            Console.ReadKey();  
            ------------------------------------------------------------------------------------------------------
            ReadLine

            int edad;
            string nombre;
            double sueldo;
            bool casado;
            
            Console.Write("Cual es tu nombre? ");
            nombre= Console.ReadLine();
            Console.Write("Cual es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cual es tu sueldo?");
            sueldo= Convert.ToDouble(Console.ReadLine());  
            Console.Write("Estas casado?: " );
            casado= Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine("Tu sueldo es de: " + sueldo);
            Console.WriteLine("Estas casado: " + casado);
            Console.ReadKey();
           ---------------------------------------------------------------------------------------
            Variables constantes
            

            string Nombre;
            int Edad;
            const double Sueldo= 2500;

            Nombre = "Victor";
            Edad = 27;
           
            Console.WriteLine("Mi Nombre es " + Nombre + " y mi edad es " + Edad + " y teniendo el sueldo es " + Sueldo);
            Console.ReadKey();
            ----------------------------------------------------------------------------------------
            

            Variables Dinamicas
            

            dynamic Contenido;

                Contenido = 11%2;

                Console.WriteLine("Contenido: " + Contenido);
            Console.ReadKey();
            ----------------------------------------------------------------------------------------
            */


        }
    }
}
