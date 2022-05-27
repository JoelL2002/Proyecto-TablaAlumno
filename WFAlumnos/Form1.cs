using Proyecto_progra1.Entidades;
using Proyecto_progra1.Servicios;
using System.Data;

namespace WFAlumnos
{
    public partial class Form1 : Form
    {
        ServiciosAlumno srvAlumno = new();
        MdAlumno alum = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Conexion_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }

        void mapeoDatosFormulario(MdAlumno alumo)
        {
            textBoxCarnet.Text = alumo.carnet;
            textBoxNombre.Text = alumo.nombre;
            textBoxCorreo.Text = alumo.correo;
            comboBoxClase.Text = alumo.clase;
            comboBoxSeccion.Text = alumo.seccion;
            textBoxPrimerP.Text = alumo.parcial1;
            textBoxSegundoP.Text = alumo.parcial2;
            textBoxTercerP.Text = alumo.parcial3;
        }

        void bucarAlumno(string carnet)
        {
            alum = null;
            alum = srvAlumno.ObtenerAlumno(carnet);

            if (alum == null)
            {
                MessageBox.Show("Dejemos de invocar seres inexistentes");
                LimpiarFormulario();
            }
            else
            {
                mapeoDatosFormulario(alum);
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            bucarAlumno(carnet);

        }

        void cargaGrid()
        {
            var respuesta = srvAlumno.ConsultaSQL($"Select * from tb_alumnos");
            dataGridViewAlumno.DataSource = respuesta;
        }


        void LimpiarFormulario()
        {
            alum = new();
            mapeoDatosFormulario(alum);
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private MdAlumno DatosFormulario()
        {
            MdAlumno _alumno = new();
            _alumno.carnet = textBoxCarnet.Text.Trim();
            _alumno.nombre = textBoxNombre.Text.Trim();
            _alumno.correo = textBoxCorreo.Text.Trim();
            _alumno.seccion = comboBoxSeccion.Text;
            _alumno.clase = comboBoxClase.Text;

            _alumno.parcial1 = textBoxPrimerP.Text.Trim();
            _alumno.parcial2 = textBoxSegundoP.Text.Trim();
            _alumno.parcial3 = textBoxTercerP.Text.Trim();
            return _alumno;
        }
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            carnetduplicado();
            nombrevacio();
            verificacionparcial();

           if(carnetduplicado() != 0)
           {
                if (nombrevacio() != 0)
                {
                    if (verificacionparcial() != 0)
                    {
                        alum = DatosFormulario();
                        int respuesta = srvAlumno.crearAlumno(alum);

                        if (respuesta > 0)
                        {
                            MessageBox.Show("Se grabo con exito");
                            LimpiarFormulario();
                            cargaGrid();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al grabar");
                        }
                    }
                    else { MessageBox.Show("Hubo un erro con las notas del parcial verifique que no exceda el limite"); }
                }
                else { MessageBox.Show("No puede dejar el nombre vacio"); }
           }
            else { MessageBox.Show("El carnet esta duplicado"); }

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
           
            nombrevacio();
            verificacionparcial();
            
                if (nombrevacio() != 0)
                {
                    if (verificacionparcial() != 0)
                    {
                        alum = DatosFormulario();
                        int respuesta = srvAlumno.actualizarAlumno(alum);

                        if (respuesta > 0)
                        {
                            MessageBox.Show("Se grabo con exito");
                            LimpiarFormulario();
                            cargaGrid();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error");
                        }
                    }
                    else { MessageBox.Show("Hubo un erro con las notas del parcial verifique que no exceda el limite"); }
                }
                else { MessageBox.Show("No puede dejar el nombre vacio"); }
            
            
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Downloads\alumnos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.Importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Downloads\pruebaexport.csv";
            ClsImportExport exp = new();
            MessageBox.Show(exp.Exportar("Select  * from tb_alumnos", archivo));
        }
        
       
        private int verificacionparcial()
        {
            
                alum = DatosFormulario();
                int accesoParciales = 0;
                


                int p1, p2, p3;
                p1 = Convert.ToInt32(alum.parcial1);
                p2 = Convert.ToInt32(alum.parcial2);
                p3 = Convert.ToInt32(alum.parcial3);



                if (p1 <= 20 && p2 <= 20 && p3 <= 35)
                {
                accesoParciales = 1;
                }

                else if (p1 > 20 && p2 > 20 && p3 > 35)
                {
                    accesoParciales = 0;
                }
              
               return accesoParciales;  
        }

        private int carnetduplicado()
        {
            alum = DatosFormulario();
            int accesoCarnet = -1;


            string Pcarnet = alum.carnet;
            DataTable resp = srvAlumno.ConsultaSQL($"Select * from tb_alumnos where carnet = '{Pcarnet}'");
            int hayalum = resp.Rows.Count;

            if (hayalum > 0)
            {
                accesoCarnet = 0;
            }
            else { accesoCarnet = 1; }

            return accesoCarnet;

        }

        private int nombrevacio()
        {          
            int accesoNombre = 0;
            int nombre = textBoxNombre.Text.Length;
           
            if(nombre > 0)
            {
                accesoNombre = 1;
            }
            return accesoNombre;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            alum = DatosFormulario();

            if (MessageBox.Show("¿De verdad desea eliminar a este alumno? no sea malo", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int respuesta = srvAlumno.borrarAlumno(alum.carnet);

                if (respuesta > 0)
                {
                    MessageBox.Show("Se elimino con exito");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }
            else
            {
                MessageBox.Show("Se cancelado la eliminacion, hoy ganamos");
                LimpiarFormulario();
            }
        }
        
        private void checkBoxModificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificacion.Checked)
            {
                textBoxNombre.ReadOnly = false;
                textBoxCorreo.ReadOnly = false;

                comboBoxClase.Items.Add("PROGRAMACION 1") ;
                comboBoxClase.Items.Add("PROGRAMACION 0");
                comboBoxClase.Items.Add("NO PROGRAMACION");
                comboBoxClase.Items.Add("PROGRAMACION NEGATIVA");

                comboBoxSeccion.Items.Add("A");
                comboBoxSeccion.Items.Add("B");
                comboBoxSeccion.Items.Add("C");
                comboBoxSeccion.Items.Add("D");

            }
            else
            {
                textBoxNombre.ReadOnly = true;  
                textBoxCorreo.ReadOnly = true;

                comboBoxClase.Items.Clear();
                comboBoxSeccion.Items.Clear();
            }
        }

        private void checkBoxParciales_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxParciales.Checked)
            {
                textBoxPrimerP.ReadOnly = false;
                textBoxSegundoP.ReadOnly = false;
                textBoxTercerP.ReadOnly= false;  
            }
            else
            {
                textBoxPrimerP.ReadOnly = true;
                textBoxSegundoP.ReadOnly= true;
                textBoxTercerP.ReadOnly= true;  
            }
        }
    }
 }