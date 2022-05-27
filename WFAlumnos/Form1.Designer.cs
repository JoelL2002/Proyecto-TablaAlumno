namespace WFAlumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1Conexion = new System.Windows.Forms.Button();
            this.dataGridViewAlumno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrimerParcial = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxPrimerP = new System.Windows.Forms.TextBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSegundoP = new System.Windows.Forms.TextBox();
            this.textBoxTercerP = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.checkBoxModificacion = new System.Windows.Forms.CheckBox();
            this.checkBoxParciales = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Conexion
            // 
            this.button1Conexion.Location = new System.Drawing.Point(550, 489);
            this.button1Conexion.Name = "button1Conexion";
            this.button1Conexion.Size = new System.Drawing.Size(191, 30);
            this.button1Conexion.TabIndex = 0;
            this.button1Conexion.Text = "Ver tabla";
            this.button1Conexion.UseVisualStyleBackColor = true;
            this.button1Conexion.Click += new System.EventHandler(this.button1Conexion_Click);
            // 
            // dataGridViewAlumno
            // 
            this.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(769, 0);
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.RowHeadersWidth = 51;
            this.dataGridViewAlumno.RowTemplate.Height = 29;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(563, 530);
            this.dataGridViewAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clase";
            // 
            // labelPrimerParcial
            // 
            this.labelPrimerParcial.AutoSize = true;
            this.labelPrimerParcial.Location = new System.Drawing.Point(35, 316);
            this.labelPrimerParcial.Name = "labelPrimerParcial";
            this.labelPrimerParcial.Size = new System.Drawing.Size(64, 20);
            this.labelPrimerParcial.TabIndex = 7;
            this.labelPrimerParcial.Text = "Parcial 1";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(127, 82);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(134, 27);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(127, 117);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(417, 27);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(127, 155);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.ReadOnly = true;
            this.textBoxCorreo.Size = new System.Drawing.Size(417, 27);
            this.textBoxCorreo.TabIndex = 11;
            // 
            // textBoxPrimerP
            // 
            this.textBoxPrimerP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrimerP.Location = new System.Drawing.Point(116, 308);
            this.textBoxPrimerP.Name = "textBoxPrimerP";
            this.textBoxPrimerP.ReadOnly = true;
            this.textBoxPrimerP.Size = new System.Drawing.Size(61, 27);
            this.textBoxPrimerP.TabIndex = 13;
            this.textBoxPrimerP.Text = "0";
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Location = new System.Drawing.Point(127, 196);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(75, 28);
            this.comboBoxSeccion.TabIndex = 14;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Location = new System.Drawing.Point(127, 233);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(313, 28);
            this.comboBoxClase.TabIndex = 15;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(450, 78);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(94, 27);
            this.buttonConsulta.TabIndex = 16;
            this.buttonConsulta.Text = "Consulta";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(550, 78);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(110, 27);
            this.buttonLimpiar.TabIndex = 17;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(55, 391);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(111, 40);
            this.buttonInsertar.TabIndex = 18;
            this.buttonInsertar.Text = "Insertar Alumno";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(291, 391);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(115, 40);
            this.buttonActualizar.TabIndex = 19;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Location = new System.Drawing.Point(12, 482);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(88, 37);
            this.buttonImportar.TabIndex = 20;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(106, 482);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(99, 37);
            this.buttonExportar.TabIndex = 21;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Parcial 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Parcial 3";
            // 
            // textBoxSegundoP
            // 
            this.textBoxSegundoP.Location = new System.Drawing.Point(329, 308);
            this.textBoxSegundoP.Name = "textBoxSegundoP";
            this.textBoxSegundoP.ReadOnly = true;
            this.textBoxSegundoP.Size = new System.Drawing.Size(61, 27);
            this.textBoxSegundoP.TabIndex = 24;
            this.textBoxSegundoP.Text = "0";
            // 
            // textBoxTercerP
            // 
            this.textBoxTercerP.Location = new System.Drawing.Point(550, 301);
            this.textBoxTercerP.Name = "textBoxTercerP";
            this.textBoxTercerP.ReadOnly = true;
            this.textBoxTercerP.Size = new System.Drawing.Size(61, 27);
            this.textBoxTercerP.TabIndex = 25;
            this.textBoxTercerP.Text = "0";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(550, 391);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(101, 40);
            this.buttonEliminar.TabIndex = 26;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // checkBoxModificacion
            // 
            this.checkBoxModificacion.AutoSize = true;
            this.checkBoxModificacion.Location = new System.Drawing.Point(39, 32);
            this.checkBoxModificacion.Name = "checkBoxModificacion";
            this.checkBoxModificacion.Size = new System.Drawing.Size(264, 24);
            this.checkBoxModificacion.TabIndex = 27;
            this.checkBoxModificacion.Text = "Modificar, agregar y eliminar datos";
            this.checkBoxModificacion.UseVisualStyleBackColor = true;
            this.checkBoxModificacion.CheckedChanged += new System.EventHandler(this.checkBoxModificacion_CheckedChanged);
            // 
            // checkBoxParciales
            // 
            this.checkBoxParciales.AutoSize = true;
            this.checkBoxParciales.Location = new System.Drawing.Point(39, 267);
            this.checkBoxParciales.Name = "checkBoxParciales";
            this.checkBoxParciales.Size = new System.Drawing.Size(288, 24);
            this.checkBoxParciales.TabIndex = 28;
            this.checkBoxParciales.Text = "Modificar o agregar notas de parciales";
            this.checkBoxParciales.UseVisualStyleBackColor = true;
            this.checkBoxParciales.CheckedChanged += new System.EventHandler(this.checkBoxParciales_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 530);
            this.Controls.Add(this.checkBoxParciales);
            this.Controls.Add(this.checkBoxModificacion);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxTercerP);
            this.Controls.Add(this.textBoxSegundoP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.textBoxPrimerP);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.labelPrimerParcial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumno);
            this.Controls.Add(this.button1Conexion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1Conexion;
        private DataGridView dataGridViewAlumno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelPrimerParcial;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private TextBox textBoxPrimerP;
        private ComboBox comboBoxSeccion;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private Button buttonLimpiar;
        private Button buttonInsertar;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private Label label6;
        private Label label7;
        private TextBox textBoxSegundoP;
        private TextBox textBoxTercerP;
        private Button buttonEliminar;
        private CheckBox checkBoxModificacion;
        private CheckBox checkBoxParciales;
    }
}