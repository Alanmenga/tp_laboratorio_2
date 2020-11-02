using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException(string mensaje, Exception innerExcepcion) 
            : base(mensaje, innerExcepcion)
        {

        }
        public ArchivosException(string mensaje) 
            : base(mensaje)
        {

        }
        public ArchivosException() 
            : base("Error en lectura o escritura de archivo")
        {

        }

    }
}
