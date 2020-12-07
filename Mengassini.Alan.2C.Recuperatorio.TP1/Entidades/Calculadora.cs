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
            char.TryParse(operador, out op);
            switch (ValidarOperador(op))
            {
                case "*":
                    return num1 * num2;
                case "-":
                    return num1 - num2;
                case "/":
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }
        public static string ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '/':
                    return "/";
                case '*':
                    return "*";
                case '-':
                    return "-";
                default:
                    return "+";
            }
        }
    }

}
