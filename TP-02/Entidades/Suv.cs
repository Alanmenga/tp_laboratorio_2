using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        //Constructor que recibe "marca,chasis,color"
        //Se los pasa al constructor de la base(vehiculo).
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            :base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        //Override del metodo mostrar
        //Muestra los datos de la base(vehiculo)
        //Y del SUV
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(String.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
