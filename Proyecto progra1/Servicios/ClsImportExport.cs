using Proyecto_progra1.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra1.Servicios
{
    public class ClsImportExport
    {
        private ClsConexion cone;

        public ClsImportExport()
        {
            cone = new ClsConexion();
        }

        public string Importar(string archivo)
        {
            string texto = "";

            try
            {
                texto = System.IO.File.ReadAllText(archivo);
                return $"Procesados: {cone.EjecutarsqlDirecto(texto)}";
            }
            catch(Exception ex)
            {
                return $"Hubo un error {ex.Message}";
            }
        }

        public string Exportar(string instruccion, string archivoDestino)
        {
            string textoSalida = "";
            DataTable respuesta = cone.ConsultaTablaDirecta(instruccion);

            foreach(DataRow dr in respuesta.Rows)
            {
                textoSalida += $"{dr["idAlumno"]};{dr["carnet"]};{dr["nombre"]};{dr["correo"]};{dr["clase"]};{dr["seccion"]};{dr["parcial1"]};{dr["parcial2"]};{dr["parcial3"]}\n";
            }
            if(!string.IsNullOrEmpty(textoSalida))
            {
                try
                {
                    File.WriteAllText(archivoDestino, textoSalida);
                    return $"Procesado: {archivoDestino}";  
                }catch(Exception ex)
                {
                    return $"Hubo un error {ex.Message}";
                }
            }
            return "No se encontro nada";
        }
    }
}
