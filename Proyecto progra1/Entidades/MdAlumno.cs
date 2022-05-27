using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra1.Entidades
{
    public class MdAlumno
    {
        public int idAlumno { get; set; }  
        public string? nombre { get; set; }    
        public string? carnet { get; set; } 
        public string? correo { get; set; }
        public string? clase { get; set; }
        public string? seccion { get; set; }
        public string? parcial1 { get; set; } 
        public string? parcial2 { get; set; }
        public string? parcial3 { get; set; }

        public override string ToString()
        {
            return $"idAlumno{idAlumno} Nombre {nombre} Seccion {seccion}";
        }

    }
}
