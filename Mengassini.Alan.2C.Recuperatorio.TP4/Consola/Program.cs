using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Supermercado supermercado = new Supermercado();

                Producto desodorante = new Producto("desodorante", "10856");
                Producto shampoo = new Producto("shampoo", "10889");

                supermercado += desodorante;

                Console.WriteLine(supermercado.MostrarDatos(supermercado));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
