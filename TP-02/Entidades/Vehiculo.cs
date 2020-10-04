using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        //Enumerado con la marca del vehiculo
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        //Enumerado con el tamaño del vehiculo
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        //Constructor que recibe atributos(chasis,marca,color)
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio 
        {
            get;
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("CHASIS: {0}\r\n", this.chasis));
            sb.AppendLine(String.Format("MARCA : {0}\r\n", this.marca.ToString()));
            sb.AppendLine(String.Format("COLOR : {0}\r\n", this.color.ToString()));
            sb.AppendLine(String.Format("---------------------"));

            return sb.ToString();
        }

        //Sobrecarga del operador reultilizando el metodo mostrar
        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Devuelve true si son iguales, false si no lo son</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Devuelve false si son iguales, true si no lo son</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
