namespace ProyectoMockus
{
    partial class frmJustificante
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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblDepartamento = new Label();
            lblFecha = new Label();
            lblIncidencia = new Label();
            lblJustificante = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtJustificante = new TextBox();
            txtIncidencia = new TextBox();
            txtDepartamento = new TextBox();
            dtpFecha = new DateTimePicker();
            grpDatosDelTrabajador = new GroupBox();
            grpDatosDelTrabajador.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(133, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Justificante de incidencia";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(15, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.Location = new Point(278, 25);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 3;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(15, 81);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha:";
            // 
            // lblIncidencia
            // 
            lblIncidencia.AutoSize = true;
            lblIncidencia.Location = new Point(278, 81);
            lblIncidencia.Name = "lblIncidencia";
            lblIncidencia.Size = new Size(82, 21);
            lblIncidencia.TabIndex = 5;
            lblIncidencia.Text = "Incidencia:";
            // 
            // lblJustificante
            // 
            lblJustificante.AutoSize = true;
            lblJustificante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJustificante.Location = new Point(12, 137);
            lblJustificante.Name = "lblJustificante";
            lblJustificante.Size = new Size(87, 21);
            lblJustificante.TabIndex = 6;
            lblJustificante.Text = "Justificante";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(102, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 32);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDarkDark;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(290, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 32);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 9;
            // 
            // txtJustificante
            // 
            txtJustificante.Location = new Point(14, 161);
            txtJustificante.Name = "txtJustificante";
            txtJustificante.Size = new Size(198, 29);
            txtJustificante.TabIndex = 10;
            // 
            // txtIncidencia
            // 
            txtIncidencia.Location = new Point(278, 105);
            txtIncidencia.Name = "txtIncidencia";
            txtIncidencia.Size = new Size(200, 29);
            txtIncidencia.TabIndex = 11;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartamento.Location = new Point(278, 49);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 29);
            txtDepartamento.TabIndex = 12;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(12, 105);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 13;
            // 
            // grpDatosDelTrabajador
            // 
            grpDatosDelTrabajador.Controls.Add(txtIncidencia);
            grpDatosDelTrabajador.Controls.Add(dtpFecha);
            grpDatosDelTrabajador.Controls.Add(lblNombre);
            grpDatosDelTrabajador.Controls.Add(txtDepartamento);
            grpDatosDelTrabajador.Controls.Add(lblJustificante);
            grpDatosDelTrabajador.Controls.Add(txtNombre);
            grpDatosDelTrabajador.Controls.Add(txtJustificante);
            grpDatosDelTrabajador.Controls.Add(lblDepartamento);
            grpDatosDelTrabajador.Controls.Add(lblIncidencia);
            grpDatosDelTrabajador.Controls.Add(lblFecha);
            grpDatosDelTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosDelTrabajador.Location = new Point(12, 60);
            grpDatosDelTrabajador.Name = "grpDatosDelTrabajador";
            grpDatosDelTrabajador.Size = new Size(492, 225);
            grpDatosDelTrabajador.TabIndex = 14;
            grpDatosDelTrabajador.TabStop = false;
            grpDatosDelTrabajador.Text = "Datos del Trabajador";
            // 
            // frmJustificante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 349);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosDelTrabajador);
            Name = "frmJustificante";
            Text = "frmJustificante";
            grpDatosDelTrabajador.ResumeLayout(false);
            grpDatosDelTrabajador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label label3;
        private Label lblDepartamento;
        private Label lblFecha;
        private Label lblIncidencia;
        private Label lblJustificante;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtJustificante;
        private TextBox txtIncidencia;
        private TextBox txtDepartamento;
        private DateTimePicker dtpFecha;
        private GroupBox grpDatosDelTrabajador;
        public Button btnCancelar;
    }
}