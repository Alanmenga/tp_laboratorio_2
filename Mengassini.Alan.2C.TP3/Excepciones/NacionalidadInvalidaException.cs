using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException() 
            : base("Nacionalidad invalida")
        {

        }
        public NacionalidadInvalidaException(string mensaje) 
            : base(mensaje)
        {

        }
        public NacionalidadInvalidaException(string mensaje, Exception innerExcepcion) 
            : base(mensaje, innerExcepcion)
        {

        }
    }
}
