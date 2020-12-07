using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ProductoDAO
    {
        private SqlConnection conexion;

        public delegate void MensajeErrorSQL(string m);
        public static event MensajeErrorSQL errorCargaBD;

        public ProductoDAO()
        {
            string conexionString = "Server=.;Database=ProductosSupermercado;Trusted_Connection=True";
            this.conexion = new SqlConnection(conexionString);
        }

        /// <summary>
        /// Inserta un producto a la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns>true si pudo, caso contrario exception</returns>
        public void Insertar(Producto p)
        {
            try
            {
                string comand = $"INSERT INTO Productos(id,nombre) VALUES(@id,@nombre)";

                SqlCommand sqlCommand = new SqlCommand(comand, conexion);
                sqlCommand.Parameters.AddWithValue("id", p.IdProducto);
                sqlCommand.Parameters.AddWithValue("nombre", p.NombreProducto);

                conexion.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                errorCargaBD.Invoke("Problema al grabar informacion en Base de Datos");
            }
            finally
            {
                if(conexion !=null &&
                    conexion.State==System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
