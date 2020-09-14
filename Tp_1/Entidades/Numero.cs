using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Validamos e iniciamos el numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
            
        }

        /// <summary>
        /// Inicializa el numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa el numero con el valor double recibido como parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa el numero con el valor string recibido como parametro
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        /// <summary>
        /// Valida el numero ingresado como string a double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public double ValidarNumero(string strNumero)
        {
            double nro;
            if (!(string.IsNullOrWhiteSpace(strNumero)))
            {
                double.TryParse(strNumero, out nro);
                return this.numero = nro;
            }
            else
                return 0;
        }

        /// <summary>
        /// Valida que sea un numero binario y lo convierte a decimal
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string BinarioDecimal(string numero)
        {
            if (EsBinario(numero))
            {
                return "Error. Numero incorrecto";
            }
            else
                return Convert.ToInt32(numero, 2).ToString();
        }

        /// <summary>
        /// Valida que sea un numero binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            int longBin = binario.Length;
            for (int i = 0; i < longBin; i++)
            {
                if(binario[i]!='1' && binario[i]!='0')
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Convierte un string decimal en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double num;
            if (double.TryParse(numero, out num))
            {
                if (EsBinario(numero))
                {
                    return DecimalBinario(num);
                }
            }
            return DecimalBinario(0);
        }

        public string DecimalBinario(double numero)
        {
            string cadena=string.Empty;
            int nro = (int)numero;

            if (nro > 0)
            {
                while (nro > 0)
                {
                    if (nro % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    nro = (int)(nro / 2);
                }
            }
            else
            {
                if (nro == 0)
                {
                    cadena = "0";
                }
                else
                    cadena = "Error. Numero invalido";
            }
            return cadena;
        }

        /// <summary>
        /// Sobrecarga del operador - entre dos numeros
        /// </summary>
        /// <param name="nro1"></param>
        /// <param name="nro2"></param>
        /// <returns></returns>
        public static double operator -(Numero nro1,Numero nro2)
        {
            if (!(nro1 is null) && !(nro2 is null))
            {
                return nro1.numero - nro2.numero;
            }
            else
                return double.MinValue;
        }

        /// <summary>
        /// Sobrecarga del operador + entre dos numeros
        /// </summary>
        /// <param name="nro1"></param>
        /// <param name="nro2"></param>
        /// <returns></returns>
        public static double operator +(Numero nro1, Numero nro2)
        {
            if (!(nro1 is null) && !(nro2 is null))
            {
                return nro1.numero + nro2.numero;
            }
            else
                return double.MinValue;
        }

        /// <summary>
        /// Sobrecarga del operador * entre dos numeros
        /// </summary>
        /// <param name="nro1"></param>
        /// <param name="nro2"></param>
        /// <returns></returns>
        public static double operator *(Numero nro1, Numero nro2)
        {
            if (!(nro1 is null) && !(nro2 is null))
            {
                return nro1.numero * nro2.numero;
            }
            else
                return double.MinValue;
        }

        /// <summary>
        /// Sobrecarga del operador // entre dos numeros
        /// </summary>
        /// <param name="nro1"></param>
        /// <param name="nro2"></param>
        /// <returns></returns>
        public static double operator /(Numero nro1, Numero nro2)
        {
            if (!(nro1 is null) && !(nro2 is null) && nro2.numero!=0)
            {
                return nro1.numero / nro2.numero;
            }
            else
                return double.MinValue;
        }

    }
}
