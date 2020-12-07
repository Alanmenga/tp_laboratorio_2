using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : IMostrar<Producto>
    {

        private string nombreProducto;
        private EEstado estado;
        private string idProducto;

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;

        public string NombreProducto 
        { 
            get
            {
                return this.nombreProducto;
            }
            set
            {
                this.nombreProducto = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string IdProducto 
        { 
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }

        public enum EEstado
        {
            EnStock,
            Vendido
        }

        public Producto(string nombreProducto, string idProducto)
        {
            this.nombreProducto = nombreProducto;
            this.idProducto = idProducto;
            this.estado = Producto.EEstado.EnStock;
        }

        /// <summary>
        /// Actualiza cada 4 segundos el estado del producto
        /// Pasando por enstock -> vendido
        /// </summary>
        public void CicloDeVida()
        {
            ProductoDAO productoDAO = new ProductoDAO();
            while (this.Estado != EEstado.Vendido)
            {
                System.Threading.Thread.Sleep(4000);

                switch (this.estado)
                {
                    case EEstado.EnStock:
                        this.estado = EEstado.Vendido;
                        break;
                }
                //InformaEstado.Invoke(this, EventArgs.Empty);
            }
            productoDAO.Insertar(this);
        }

        /// <summary>
        /// Muestra datos del producto
        /// </summary>
        /// <returns>string datosProducto</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Retorna informacion del producto
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns>string datosProducto</returns>
        public string MostrarDatos(IMostrar<Producto> elemento)
        {
            Producto p = (Producto)elemento;

            return String.Format($"Producto: {nombreProducto} ID: {idProducto}\n");
        }

        /// <summary>
        /// Dos productos serán iguales si tienen el mismo idProducto
        /// </summary>
        /// <param name="p1">Producto 1</param>
        /// <param name="p2">Producto 2</param>
        /// <returns>true si son iguales, caso contrario false</returns>
        public static bool operator ==(Producto p1,Producto p2)
        {
            return (p1.idProducto == p2.idProducto);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
