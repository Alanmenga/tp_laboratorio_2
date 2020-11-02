﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        public DniInvalidoException() : base("Error de Dni invalido")
        {

        }
        public DniInvalidoException(string mensaje) : base(mensaje)
        {

        }
        public DniInvalidoException(string mensaje, Exception innerExcepxion) : base(mensaje, innerExcepxion)
        {

        }
    }
}
