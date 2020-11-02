using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException(string mensaje, Exception innerExcepcion) 
            : base(mensaje, innerExcepcion)
        {

        }

        public AlumnoRepetidoException(string mensaje) 
            : base(mensaje)
        {

        }

        public AlumnoRepetidoException() 
            : base("Alumno repetido.")
        {

        }
    }
}
