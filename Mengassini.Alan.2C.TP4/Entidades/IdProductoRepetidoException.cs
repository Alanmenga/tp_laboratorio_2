using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdProductoRepetidoException:Exception
    {
        public IdProductoRepetidoException(string mensaje)
            :base(mensaje)
        {
            
        }
        public IdProductoRepetidoException(string mensaje,Exception inner)
            : base(mensaje,inner)
        {

        }
    }
}
