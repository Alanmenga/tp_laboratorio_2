using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = true;
            try
            {
                string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

                StreamWriter streamWriter = new StreamWriter(pathArchivoEnEscritorio, true);
                streamWriter.WriteLine(datos);
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                retorno = false;
                throw new ArchivosException("Error al guardar el archivo de texto.", ex);
            }

            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = true;

            try
            {
                string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

                StreamReader streamReader = new StreamReader(pathArchivoEnEscritorio);
                datos = streamReader.ReadToEnd();
                streamReader.Close();
            }
            catch (Exception ex)
            {
                datos = default(string);
                retorno = false;
                throw new ArchivosException("Error al leer el archivo de texto.", ex);
            }

            return retorno;
        }
    }
}
