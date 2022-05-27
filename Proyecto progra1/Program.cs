
using Proyecto_progra1.Clases;
using Proyecto_progra1.Entidades;
using Proyecto_progra1.Servicios;

ClsConexion con = new ClsConexion();
ServiciosAlumno ej = new ServiciosAlumno();
MdAlumno alu = new MdAlumno();

//alu.nombre = "Sancho pedro";
//alu.seccion = "C";
//alu.carnet = "11-2334";
//alu.clase = "Matamoscas";

//ej.crearAlumno(alu);
//ej.lee();

alu = ej.ObtenerAlumno("11-2334");
if(alu == null)
{
    Console.WriteLine("Con que buscando seres inexistentes eh!");
}
else
{
  Console.WriteLine(alu.ToString());
    alu.seccion = "F";
    ej.actualizarAlumno(alu);
}