using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ProductoDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        public delegate void MensajeErrorSQL(string m);
        public static event MensajeErrorSQL errorCargaBD;

        static ProductoDAO()
        {
            string conexionString = @"Data Source=DESKTOP-EDJOMJ4;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conexion = new SqlConnection(conexionString);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        /// <summary>
        /// Inserta un producto a la base de datos correo-sp-2017
        /// </summary>
        /// <param name="p"></param>
        /// <returns>true si pudo, caso contrario exception</returns>
        public static bool Insertar(Producto p)
        {
            bool retorno = false;

            try
            {
                string consultaNonQuery = $"INSERT INTO dbo.Productos(nombreProducto,IdProducto,alumno) VALUES('{p.NombreProducto}','{p.IdProducto}','Alan Mengassini')";

                comando.CommandText = consultaNonQuery;

                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                errorCargaBD.Invoke("Problema al grabar informacion en Base de Datos");
            }
            finally
            {
                conexion.Close();
            }

            return retorno;

        }
    }
}
