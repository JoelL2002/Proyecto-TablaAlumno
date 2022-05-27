using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_progra1.Clases
{
    internal class ClsConexion
    {
        private string Nombreservidor = "UMG-LAB\\SQLEXPRESS";
        private string NombreBasedeDatos = "Progra1";

        public SqlConnection conexion;

        private string CadenaConexion { get;  }

        public ClsConexion()
        {
            CadenaConexion = $"Data Source={Nombreservidor}; Initial Catalog={NombreBasedeDatos}; Integrated Security =True";
        }

        /// <summary>
        /// Metodo para ejecutar una consulta de SQL y devuelve un DataTable
        /// </summary>
        /// <param name="cuerito"></param>
        /// <returns></returns>
        public DataTable ConsultaTablaDirecta(String cuerito)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))

            try
            {
                conexion.Open();
                SqlDataReader dr;
                SqlCommand comm = new SqlCommand(cuerito, conexion);
                dr = comm.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(dr);

                return dataTable;

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
                return null;
            }
        }


        public int EjecutarsqlDirecto(String instruccionsql)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                int status = -1;
                try
                {
                    conexion.Open();

                    SqlCommand comm = new SqlCommand(instruccionsql, conexion);
                    status = comm.ExecuteNonQuery();
                    return status;


                    //if (estado > 0)
                    //{
                    //    Console.WriteLine("Se ejecuto con exito");
                    //}
                }
                catch (Exception ex)
                {
                    return status;
                    

                }
            }
        }
    }
}
