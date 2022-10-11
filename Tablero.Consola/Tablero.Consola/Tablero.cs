using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablero.Consola
{
    class Tablero
    {
        //Atributos
        private string _titulo;
        private string _descripcion;
        private List<Tarea> tareas;
        private DateTime _fechaInicioProyecto;


        //Metodos

        public static void AgregarTarea()
        {
            Console.WriteLine("Para dar de alta una tarea ingrese los siguientes datos:");
            Console.WriteLine("Ingrese una descripción");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el estado de la tarea: Pendiente o Finalizada");
            string estado = Console.ReadLine();
            Console.WriteLine("Ingrese la orden");
            string orden = Console.ReadLine();
            DateTime fechaR;
            bool exito = false;

            do
            {
                Console.WriteLine("Ingrese la fecha de realización en el formato mm/dd/yyyy");
                string fecha = Console.ReadLine();
                exito = DateTime.TryParse(fecha, out fechaR);
                if (exito)
                {
                    Console.WriteLine("Fecha válida");
                }
                else { Console.WriteLine("Ingrese una fecha válida"); }

            } while (exito == false);
    


        }

        public void CambiarEstado()
        {

        }
        //public List<Tarea> TraerTareas()
        //{
        //}
        //public Tarea TraerTareaMasAntigua()
        //{

        //}
    }
}

