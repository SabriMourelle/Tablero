using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablero.Consola
{
    class Tarea
    {
        //Atributos
        private int _codigo = 0;
        private string _descripcion;
        private string _estado;
        private int _orden;
        private DateTime _fechaAlta;
        private DateTime _fechaRealizacion;
        //Constructores
        public Tarea(string descripcion, string estado, int orden, DateTime fecha)
        {
            _codigo = _codigo + 1;
            this._descripcion = descripcion;
            this._estado = estado;
            _orden = orden;
            _fechaAlta = DateTime.Today;
            _fechaRealizacion = fecha;

        }
        public Tarea()
        {

        }


        //Método
        //public bool IsFinalizada()
        //{

        //}
    }
}

