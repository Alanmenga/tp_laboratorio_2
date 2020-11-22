using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supermercado : IMostrar<List<Producto>>
    {
        private List<Thread> hiloProductos;
        private List<Producto> productos;

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        public Supermercado()
        {
            hiloProductos = new List<Thread>();
            productos = new List<Producto>();
        }

        /// <summary>
        /// Finaliza todos los threads que sigan abiertos
        /// </summary>
        public void FinCompras()
        {
            foreach (Thread t in this.hiloProductos)
            {
                if (t != null)
                {
                    if (t.IsAlive)
                    {
                        t.Abort();
                    }
                }
            }
        }

        /// <summary>
        /// Muestra datos del producto
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns>string datosProductos</returns>
        public string MostrarDatos(IMostrar<List<Producto>> elementos)
        {
            Supermercado sAux = (Supermercado)elementos;
            string datosProductos = "";

            foreach (Producto p in sAux.productos)
            {
                datosProductos += string.Format($"Producto: {p.NombreProducto} ID: {p.IdProducto} ({p.Estado.ToString()})\n");
            }
            return datosProductos;
        }

        /// <summary>
        /// Verifica y agrega un producto al supermercado
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns>supermercado</returns>
        public static Supermercado operator +(Supermercado s, Producto p)
        {
            if (s.productos is null)
            {
                s.productos.Add(p);
            }
            else
            {
                foreach (Producto item in s.productos)
                {
                    if (item == p)
                    {
                        throw new IdProductoRepetidoException("El producto ya está agregado a la lista");
                    }
                }

                s.productos.Add(p);
            }

            Thread t = new Thread(p.CicloDeVida);
            s.hiloProductos.Add(t);
            t.Start();

            return s;
        }
    }
}
