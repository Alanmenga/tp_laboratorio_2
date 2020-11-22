using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.ProductoDAO;

namespace FormSupermercado
{
    public partial class SupermercadoForm : Form
    {
        Supermercado supermercado;
        public SupermercadoForm()
        {
            InitializeComponent();
            supermercado = new Supermercado();
            ProductoDAO.errorCargaBD += ProductoDAO_errorCargaBD;
            this.richTextBoxMostrarDatos.Text = MostrarDatosStock();
        }

        /// <summary>
        /// Muestro los datos de los productos en stock
        /// </summary>
        public string MostrarDatosStock()
        {
            string datosProductos = "";
            List<Producto> productosStock = new List<Producto>();
            Producto desodorante = new Producto("desodorante", "12345");
            productosStock.Add(desodorante);
            Producto shampoo = new Producto("shampoo", "12346");
            productosStock.Add(shampoo);
            Producto cocacola = new Producto("cocacola", "12347");
            productosStock.Add(cocacola);
            Producto galletitas = new Producto("galletitas", "12346");
            productosStock.Add(galletitas);
            Producto fideos = new Producto("fideos", "12347");
            productosStock.Add(fideos);
            Producto leche = new Producto("leche", "12348");
            productosStock.Add(leche);
            Producto carne = new Producto("carne", "12349");
            productosStock.Add(carne);

            foreach (Producto p in productosStock)
            {
                datosProductos += string.Format($"Producto: {p.NombreProducto} ID: {p.IdProducto} ({p.Estado.ToString()})\n");
            }
            return datosProductos;
        }

        private void ProductoDAO_errorCargaBD(string m)
        {
            if (this.InvokeRequired)
            {
                MensajeErrorSQL d = new MensajeErrorSQL(ProductoDAO_errorCargaBD);
                this.Invoke(d, new object[] { m });
            }
            else
            {
                MessageBox.Show(m, "ERROR SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Borra los listBox y los actualiza según estado de los productos
        /// </summary>
        private void ActualizarEstados()
        {
            listBoxListaProductosComprados.Items.Clear();
            listBoxListaProductosStock.Items.Clear();

            foreach (Producto producto in this.supermercado.Productos)
            {
                switch (producto.Estado)
                {
                    case Producto.EEstado.EnStock:
                        listBoxListaProductosStock.Items.Add(producto);
                        break;
                    case Producto.EEstado.Vendido:
                        listBoxListaProductosComprados.Items.Add(producto);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Agrega producto al supermercado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCompra_Click(object sender, EventArgs e)
        {
            if (textBoxNombreProducto.Text != "" && textBoxIdProducto.Text != "")
            {
                Producto p = new Producto(textBoxNombreProducto.Text, textBoxIdProducto.Text);
                try
                {
                    this.supermercado += p;
                    p.InformaEstado += producto_InformaEstado;
                    this.ActualizarEstados();
                }
                catch (IdProductoRepetidoException)
                {
                    MessageBox.Show("Producto Repetido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta informacion del Producto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handler del evento InformaEstado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void producto_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Producto.DelegadoEstado d = new Producto.DelegadoEstado(producto_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.supermercado.FinCompras();
        }


        private void SupermercadoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.GuardarInformacion<List<Producto>>((IMostrar<List<Producto>>)supermercado);
  
            }
            catch (Exception exc)
            {
                throw new Exception("ERROR al querer mostrar paquetes!", exc);
            }
        }

        private void GuardarInformacion<T>(IMostrar<T> elemento)
        {
            try
            {
                // Chequeo que el elemento no sea nulo
                if (!(elemento is null))
                {
                    // Cargo los datos en pantalla
                    string datos = elemento.MostrarDatos((IMostrar<T>)elemento);
                    listBoxListaProductosComprados.Text = datos;

                    // Guardo datos en archivo de texto
                    datos.Guardar("Compras.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
