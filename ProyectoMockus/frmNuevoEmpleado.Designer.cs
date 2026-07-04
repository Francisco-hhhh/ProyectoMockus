namespace ProyectoMockus
{
    partial class frmNuevoEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosGenerales = new GroupBox();
            label8 = new Label();
            lblDepartamento = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            rdbMujer = new RadioButton();
            rdbHombre = new RadioButton();
            txtNombre = new TextBox();
            txtClaveTrabajador = new TextBox();
            lblApellidoMaterno = new Label();
            lblApellidoPaterno = new Label();
            lblGenero = new Label();
            lblNombre = new Label();
            lblClaveTrabajador = new Label();
            lblTitulo = new Label();
            grpGenero = new GroupBox();
            txtCodigoPostal = new TextBox();
            txtMunicipio = new TextBox();
            txtLocalidad = new TextBox();
            txtNumCalle = new TextBox();
            lblMunicipio = new Label();
            lblLocalidad = new Label();
            label3 = new Label();
            lblNumCalle = new Label();
            grpDatosDeContacto = new GroupBox();
            txtCorreoInstitucional = new TextBox();
            txtTelefono = new TextBox();
            lblCorreoInstitucional = new Label();
            lblTelefono = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpDatosGenerales.SuspendLayout();
            grpGenero.SuspendLayout();
            grpDatosDeContacto.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosGenerales
            // 
            grpDatosGenerales.Controls.Add(label8);
            grpDatosGenerales.Controls.Add(lblDepartamento);
            grpDatosGenerales.Controls.Add(comboBox2);
            grpDatosGenerales.Controls.Add(comboBox1);
            grpDatosGenerales.Controls.Add(txtApellidoMaterno);
            grpDatosGenerales.Controls.Add(txtApellidoPaterno);
            grpDatosGenerales.Controls.Add(rdbMujer);
            grpDatosGenerales.Controls.Add(rdbHombre);
            grpDatosGenerales.Controls.Add(txtNombre);
            grpDatosGenerales.Controls.Add(txtClaveTrabajador);
            grpDatosGenerales.Controls.Add(lblApellidoMaterno);
            grpDatosGenerales.Controls.Add(lblApellidoPaterno);
            grpDatosGenerales.Controls.Add(lblGenero);
            grpDatosGenerales.Controls.Add(lblNombre);
            grpDatosGenerales.Controls.Add(lblClaveTrabajador);
            grpDatosGenerales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosGenerales.Location = new Point(12, 42);
            grpDatosGenerales.Name = "grpDatosGenerales";
            grpDatosGenerales.Size = new Size(480, 253);
            grpDatosGenerales.TabIndex = 0;
            grpDatosGenerales.TabStop = false;
            grpDatosGenerales.Text = "Datos Generales";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(257, 190);
            label8.Name = "label8";
            label8.Size = new Size(60, 21);
            label8.TabIndex = 15;
            label8.Text = "Puesto:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.Location = new Point(17, 190);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 14;
            lblDepartamento.Text = "Departamento:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(257, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 29);
            comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 29);
            comboBox1.TabIndex = 12;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(257, 158);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(200, 29);
            txtApellidoMaterno.TabIndex = 11;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(17, 158);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(200, 29);
            txtApellidoPaterno.TabIndex = 10;
            // 
            // rdbMujer
            // 
            rdbMujer.AutoSize = true;
            rdbMujer.CheckAlign = ContentAlignment.MiddleRight;
            rdbMujer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMujer.Location = new Point(71, 105);
            rdbMujer.Name = "rdbMujer";
            rdbMujer.Size = new Size(45, 25);
            rdbMujer.TabIndex = 9;
            rdbMujer.TabStop = true;
            rdbMujer.Text = "M:";
            rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            rdbHombre.AutoSize = true;
            rdbHombre.CheckAlign = ContentAlignment.MiddleRight;
            rdbHombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbHombre.Location = new Point(16, 105);
            rdbHombre.Name = "rdbHombre";
            rdbHombre.Size = new Size(42, 25);
            rdbHombre.TabIndex = 8;
            rdbHombre.TabStop = true;
            rdbHombre.Text = "H:";
            rdbHombre.TextAlign = ContentAlignment.BottomRight;
            rdbHombre.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(257, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.Location = new Point(16, 48);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(200, 29);
            txtClaveTrabajador.TabIndex = 6;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.Location = new Point(257, 134);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(133, 21);
            lblApellidoMaterno.TabIndex = 4;
            lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.Location = new Point(17, 134);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(127, 21);
            lblApellidoPaterno.TabIndex = 3;
            lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(16, 80);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(64, 21);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Genero:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(257, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre(s):";
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClaveTrabajador.Location = new Point(16, 24);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(151, 21);
            lblClaveTrabajador.TabIndex = 0;
            lblClaveTrabajador.Text = "Clave del Trabajador";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(104, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Nuevo Empleado";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(txtCodigoPostal);
            grpGenero.Controls.Add(txtMunicipio);
            grpGenero.Controls.Add(txtLocalidad);
            grpGenero.Controls.Add(txtNumCalle);
            grpGenero.Controls.Add(lblMunicipio);
            grpGenero.Controls.Add(lblLocalidad);
            grpGenero.Controls.Add(label3);
            grpGenero.Controls.Add(lblNumCalle);
            grpGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpGenero.Location = new Point(12, 301);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(480, 134);
            grpGenero.TabIndex = 2;
            grpGenero.TabStop = false;
            grpGenero.Text = "Direccion";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(257, 41);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(200, 29);
            txtCodigoPostal.TabIndex = 7;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(257, 96);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(200, 29);
            txtMunicipio.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(16, 96);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(200, 29);
            txtLocalidad.TabIndex = 5;
            // 
            // txtNumCalle
            // 
            txtNumCalle.Location = new Point(16, 41);
            txtNumCalle.Name = "txtNumCalle";
            txtNumCalle.Size = new Size(200, 29);
            txtNumCalle.TabIndex = 4;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMunicipio.Location = new Point(257, 72);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(82, 21);
            lblMunicipio.TabIndex = 3;
            lblMunicipio.Text = "Municipio:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalidad.Location = new Point(16, 72);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(79, 21);
            lblLocalidad.TabIndex = 2;
            lblLocalidad.Text = "Localidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 17);
            label3.Name = "label3";
            label3.Size = new Size(35, 21);
            label3.TabIndex = 1;
            label3.Text = "C.P:";
            // 
            // lblNumCalle
            // 
            lblNumCalle.AutoSize = true;
            lblNumCalle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCalle.Location = new Point(17, 19);
            lblNumCalle.Name = "lblNumCalle";
            lblNumCalle.Size = new Size(89, 21);
            lblNumCalle.TabIndex = 0;
            lblNumCalle.Text = "Num. Calle:";
            // 
            // grpDatosDeContacto
            // 
            grpDatosDeContacto.Controls.Add(txtCorreoInstitucional);
            grpDatosDeContacto.Controls.Add(txtTelefono);
            grpDatosDeContacto.Controls.Add(lblCorreoInstitucional);
            grpDatosDeContacto.Controls.Add(lblTelefono);
            grpDatosDeContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosDeContacto.Location = new Point(12, 441);
            grpDatosDeContacto.Name = "grpDatosDeContacto";
            grpDatosDeContacto.Size = new Size(480, 83);
            grpDatosDeContacto.TabIndex = 3;
            grpDatosDeContacto.TabStop = false;
            grpDatosDeContacto.Text = "Datos de Contacto";
            // 
            // txtCorreoInstitucional
            // 
            txtCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoInstitucional.Location = new Point(257, 43);
            txtCorreoInstitucional.Name = "txtCorreoInstitucional";
            txtCorreoInstitucional.Size = new Size(200, 29);
            txtCorreoInstitucional.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(17, 43);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 29);
            txtTelefono.TabIndex = 2;
            // 
            // lblCorreoInstitucional
            // 
            lblCorreoInstitucional.AutoSize = true;
            lblCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoInstitucional.Location = new Point(257, 19);
            lblCorreoInstitucional.Name = "lblCorreoInstitucional";
            lblCorreoInstitucional.Size = new Size(150, 21);
            lblCorreoInstitucional.TabIndex = 1;
            lblCorreoInstitucional.Text = "Correo Insititucional";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(17, 19);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Telefono";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(12, 542);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDarkDark;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(372, 542);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 589);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatosDeContacto);
            Controls.Add(grpGenero);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosGenerales);
            Name = "frmNuevoEmpleado";
            Text = "frmNuevoEmpleado";
            grpDatosGenerales.ResumeLayout(false);
            grpDatosGenerales.PerformLayout();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpDatosDeContacto.ResumeLayout(false);
            grpDatosDeContacto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosGenerales;
        private Label lblTitulo;
        private Label lblApellidoMaterno;
        private Label lblApellidoPaterno;
        private Label lblGenero;
        private Label lblNombre;
        private Label lblClaveTrabajador;
        private TextBox txtNombre;
        private TextBox txtClaveTrabajador;
        private RadioButton rdbHombre;
        private RadioButton rdbMujer;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private GroupBox grpGenero;
        private TextBox txtLocalidad;
        private TextBox txtNumCalle;
        private Label lblMunicipio;
        private Label lblLocalidad;
        private Label label3;
        private Label lblNumCalle;
        private TextBox txtCodigoPostal;
        private TextBox txtMunicipio;
        private GroupBox grpDatosDeContacto;
        private TextBox txtCorreoInstitucional;
        private TextBox txtTelefono;
        private Label lblCorreoInstitucional;
        private Label lblTelefono;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label8;
        private Label lblDepartamento;
    }
}