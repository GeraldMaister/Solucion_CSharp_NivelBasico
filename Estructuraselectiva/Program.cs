using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuraselectiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Switch o estructura selectiva
             * Sirve para que la informacion ingresada pase por un filtro y en el que encaje procedera a realizar
               Dicha funcion.
             */

            int Dia;

            Console.WriteLine("Ingrese el dia en numero: ");
            Dia= int.Parse(Console.ReadLine());

            switch(Dia)
            {
                case 1: Console.WriteLine("Es Lunes");
                    break;

                    case 2: Console.WriteLine("Es Martes");
                    break;
                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Es Viernes");
                    break;

                case 6:
                    Console.WriteLine("Es Sabado");
                    break;
                case 7:
                    Console.WriteLine("Es Domingo");
                    break;

                default: Console.WriteLine("El numero de dia ingresado no es valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
