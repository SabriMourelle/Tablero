using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablero.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Se desea hacer un Tablero de tareas donde: .
            //            Se debe poder dar de alta una tarea. El tablero asigna el codigo de tarea de forma correlativa autómaticamente. .
            //            Se debe poder traer las tareas por estado(si el estado es null or empty trae todos) en base al orden. .
            //            Se debe poder preguntar si una tarea está finalizada.
            //            Se debe poder Consultar la tarea más antigua. .
            //            Se debe poder cambiar el estado de una tarea.

            //Extra: divididas en tareas comunes y tareas especiales
            int opcion;
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Tablero.AgregarTarea();
                    break;

                case 2:
                    Console.WriteLine("Traer tarea por estado");
                    break;

                case 3:
                    Console.WriteLine("Ver si una tarea está finalizada");
                    break;
                case 4:
                    Console.WriteLine("Consultar la tarea más antigua");
                    break;

                case 5:
                    Console.WriteLine("Cambiar el estado de una tarea");
                    break;

                default:
                    break;
            }




        }
        //Método
        public static void MostrarMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("Opción 1: Dar de alta una tarea");
            Console.WriteLine("Opción 2: Traer tarea por estado");
            Console.WriteLine("Opción 3: Ver si una tarea está finalizada");
            Console.WriteLine("Opción 4: Consultar la tarea más antigua");
            Console.WriteLine("Opción 5: Cambiar el estado de una tarea");
        }
    }
}
