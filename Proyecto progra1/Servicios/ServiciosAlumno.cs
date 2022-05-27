using Proyecto_progra1.Clases;
using Proyecto_progra1.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra1.Servicios
{
    public class ServiciosAlumno
    {
    public int promedios(string seccion)
        {
           
            ClsConexion cone = new();
            DataTable resp = cone.ConsultaTablaDirecta($"Select * from tb_alumnos where seccion = '{seccion}'");

            int acumulador = 0;
            foreach (DataRow dr in resp.Rows)
            {
                acumulador = acumulador + Convert.ToInt32(dr["parcial1"]);
                Console.WriteLine($"Seccion = {dr["seccion"]} Carnet = {dr["carnet"]} nombre = {dr["nombre"]} parcial1 = {dr["parcial1"]}");
            }
            int promedio = acumulador/resp.Rows.Count;
            return promedio;
        }

        public void lee()
        {

            ClsConexion cone = new();
            DataTable resp = cone.ConsultaTablaDirecta($"Select * from tb_alumnos");

            
            foreach (DataRow dr in resp.Rows)
            {
               
                Console.WriteLine($"Seccion = {dr["seccion"]} Carnet = {dr["carnet"]} nombre = {dr["nombre"]} parcial1 = {dr["parcial1"]}");
            }
                    
        }

        public DataTable ConsultaSQL(string consulta)
        {

            ClsConexion cone = new();
            DataTable resp = cone.ConsultaTablaDirecta(consulta);


            return resp;
        }


        public int actualizarAlumno(MdAlumno alu)
        {
            ClsConexion conse = new();
            string instruccion = ($"Update tb_alumnos set  nombre = '{alu.nombre}', correo = '{alu.correo}', clase = '{alu.clase}', seccion = '{alu.seccion}', parcial1 = '{alu.parcial1}', parcial2 = '{alu.parcial2}', parcial3 = '{alu.parcial3}' where carnet = '{alu.carnet}' ");
            return conse.EjecutarsqlDirecto(instruccion);
        }

        public void insertar(string carnet, string nombre, string correo, string clase, string seccion)
        {
            ClsConexion cone = new();
            string instruccion = $"insert into tb_alumnos (carnet,nombre,correo,clase,seccion) values('{carnet}', '{nombre}', '{correo}', '{clase}', '{seccion}')";
            cone.EjecutarsqlDirecto(instruccion);   
        }


        public int crearAlumno(MdAlumno alu)
        {
            ClsConexion cone = new();
            string instruccion = $"insert into tb_alumnos (carnet,nombre,correo,clase,seccion, parcial1, parcial2, parcial3) values('{alu.carnet}', '{alu.nombre}', '{alu.correo}', '{alu.clase}', '{alu.seccion}', '{alu.parcial1}', '{alu.parcial2}', '{alu.parcial3}')";
            return cone.EjecutarsqlDirecto(instruccion);
        }

        public int borrarAlumno(string carnet)
        {
            ClsConexion cone = new();
            string instruccion = $"Delete from tb_alumnos where carnet = '{carnet}'";
            return cone.EjecutarsqlDirecto(instruccion);
        }

        public MdAlumno ObtenerAlumno(string carnet)
        {
            ClsConexion conn = new();
            MdAlumno alu = new();

            DataTable resp = conn.ConsultaTablaDirecta($"select * from tb_alumnos where carnet='{carnet}'");
            if (resp.Rows.Count > 0)
            {
                foreach (DataRow item in resp.Rows)
                {
                    alu.idAlumno = Convert.ToInt32(item["idAlumno"]);
                    alu.carnet = item["carnet"].ToString();
                    alu.nombre = item["nombre"].ToString();
                    alu.seccion = item["seccion"].ToString();
                    alu.clase = item["clase"].ToString();
                    alu.correo = item["correo"].ToString();
                    alu.parcial1 = item["parcial1"].ToString();
                    alu.parcial2 = item["parcial2"].ToString();
                    alu.parcial3 = item["parcial3"].ToString();

                }
                return alu;
            }
            else { return null; }
        }
    }
}
