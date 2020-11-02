﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        public SinProfesorException() 
            : base("No hay profesores para esa clase.")
        {

        }
        public SinProfesorException(string mensaje, Exception innerExcepcion) 
            : base(mensaje, innerExcepcion)
        {

        }
        public SinProfesorException(string mensaje) 
            : base(mensaje)
        {

        }
    }
}
