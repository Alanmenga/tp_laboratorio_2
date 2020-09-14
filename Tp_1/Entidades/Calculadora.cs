using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char op;
            op = Convert.ToChar(operador);
            double resultado = 0;
            switch (ValidarOperador(op))
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
        public static string ValidarOperador(char operador)
        {
            string op;
            if (char.IsWhiteSpace(operador))
            {
                operador = '+';
            }
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                operador = '+';
            }
            op = char.ToString(operador);
            return op;
        }
    }

}
