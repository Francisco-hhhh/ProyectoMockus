namespace ProyectoMockus
{
    partial class frmAsignacionHorarios
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
            grpBuscarTrabajador = new GroupBox();
            grpDatosTrabajador = new GroupBox();
            lblTitulo = new Label();
            lblClaveTrabaj = new Label();
            txtBusacarClave = new TextBox();
            btnBuscar = new Button();
            lblNombreCompleto = new Label();
            lblSemestre = new Label();
            lblDepartamento = new Label();
            lblPuesto = new Label();
            txtBuscarNombreCompleto = new TextBox();
            txtSemestre = new TextBox();
            txtDepartamento = new TextBox();
            txtPuesto = new TextBox();
            grpHorario = new GroupBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dtpHoraEntrada = new DateTimePicker();
            lblHoraEntrada = new Label();
            dtpHoraSalida = new DateTimePicker();
            lblHoraSalida = new Label();
            chkLunes = new CheckBox();
            chkMartes = new CheckBox();
            chkMiercoles = new CheckBox();
            chkJueves = new CheckBox();
            chkViernes = new CheckBox();
            lblDias = new Label();
            grpBuscarTrabajador.SuspendLayout();
            grpDatosTrabajador.SuspendLayout();
            grpHorario.SuspendLayout();
            SuspendLayout();
            // 
            // grpBuscarTrabajador
            // 
            grpBuscarTrabajador.Controls.Add(btnBuscar);
            grpBuscarTrabajador.Controls.Add(txtBusacarClave);
            grpBuscarTrabajador.Controls.Add(lblClaveTrabaj);
            grpBuscarTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBuscarTrabajador.Location = new Point(12, 37);
            grpBuscarTrabajador.Name = "grpBuscarTrabajador";
            grpBuscarTrabajador.Size = new Size(460, 87);
            grpBuscarTrabajador.TabIndex = 0;
            grpBuscarTrabajador.TabStop = false;
            grpBuscarTrabajador.Text = "Buscar Trabajador";
            // 
            // grpDatosTrabajador
            // 
            grpDatosTrabajador.Controls.Add(txtPuesto);
            grpDatosTrabajador.Controls.Add(txtDepartamento);
            grpDatosTrabajador.Controls.Add(txtSemestre);
            grpDatosTrabajador.Controls.Add(txtBuscarNombreCompleto);
            grpDatosTrabajador.Controls.Add(lblPuesto);
            grpDatosTrabajador.Controls.Add(lblDepartamento);
            grpDatosTrabajador.Controls.Add(lblSemestre);
            grpDatosTrabajador.Controls.Add(lblNombreCompleto);
            grpDatosTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosTrabajador.Location = new Point(12, 130);
            grpDatosTrabajador.Name = "grpDatosTrabajador";
            grpDatosTrabajador.Size = new Size(460, 145);
            grpDatosTrabajador.TabIndex = 1;
            grpDatosTrabajador.TabStop = false;
            grpDatosTrabajador.Text = "Datos Del Trabajador";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(141, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Asignacion de Horario";
            // 
            // lblClaveTrabaj
            // 
            lblClaveTrabaj.AutoSize = true;
            lblClaveTrabaj.Location = new Point(18, 25);
            lblClaveTrabaj.Name = "lblClaveTrabaj";
            lblClaveTrabaj.Size = new Size(154, 21);
            lblClaveTrabaj.TabIndex = 0;
            lblClaveTrabaj.Text = "Clave del Trabajador:";
            // 
            // txtBusacarClave
            // 
            txtBusacarClave.Location = new Point(18, 49);
            txtBusacarClave.Name = "txtBusacarClave";
            txtBusacarClave.Size = new Size(150, 29);
            txtBusacarClave.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(293, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 26);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(18, 25);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(143, 21);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Location = new Point(247, 25);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(78, 21);
            lblSemestre.TabIndex = 1;
            lblSemestre.Text = "Semestre:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(18, 81);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(247, 81);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(60, 21);
            lblPuesto.TabIndex = 3;
            lblPuesto.Text = "Puesto:";
            // 
            // txtBuscarNombreCompleto
            // 
            txtBuscarNombreCompleto.Location = new Point(18, 49);
            txtBuscarNombreCompleto.Name = "txtBuscarNombreCompleto";
            txtBuscarNombreCompleto.Size = new Size(200, 29);
            txtBuscarNombreCompleto.TabIndex = 4;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(247, 49);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(200, 29);
            txtSemestre.TabIndex = 5;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(18, 105);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 29);
            txtDepartamento.TabIndex = 6;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(247, 105);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(200, 29);
            txtPuesto.TabIndex = 7;
            // 
            // grpHorario
            // 
            grpHorario.Controls.Add(lblDias);
            grpHorario.Controls.Add(chkViernes);
            grpHorario.Controls.Add(chkJueves);
            grpHorario.Controls.Add(chkMiercoles);
            grpHorario.Controls.Add(chkMartes);
            grpHorario.Controls.Add(chkLunes);
            grpHorario.Controls.Add(lblHoraSalida);
            grpHorario.Controls.Add(dtpHoraSalida);
            grpHorario.Controls.Add(lblHoraEntrada);
            grpHorario.Controls.Add(dtpHoraEntrada);
            grpHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpHorario.Location = new Point(12, 281);
            grpHorario.Name = "grpHorario";
            grpHorario.Size = new Size(460, 178);
            grpHorario.TabIndex = 3;
            grpHorario.TabStop = false;
            grpHorario.Text = "Horario";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(12, 465);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 32);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDarkDark;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(372, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dtpHoraEntrada
            // 
            dtpHoraEntrada.Format = DateTimePickerFormat.Time;
            dtpHoraEntrada.Location = new Point(18, 47);
            dtpHoraEntrada.MinDate = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            dtpHoraEntrada.Name = "dtpHoraEntrada";
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Size = new Size(122, 29);
            dtpHoraEntrada.TabIndex = 0;
            dtpHoraEntrada.Value = new DateTime(2026, 7, 4, 7, 0, 0, 0);
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Location = new Point(18, 23);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(122, 21);
            lblHoraEntrada.TabIndex = 1;
            lblHoraEntrada.Text = "Hora de Entrada";
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(18, 103);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(122, 29);
            dtpHoraSalida.TabIndex = 2;
            dtpHoraSalida.Value = new DateTime(2026, 7, 4, 15, 0, 0, 0);
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Location = new Point(18, 79);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(111, 21);
            lblHoraSalida.TabIndex = 3;
            lblHoraSalida.Text = "Hora de Salida";
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLunes.Location = new Point(67, 143);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(56, 17);
            chkLunes.TabIndex = 4;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMartes.Location = new Point(129, 142);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(61, 17);
            chkMartes.TabIndex = 5;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMiercoles.Location = new Point(196, 143);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(75, 17);
            chkMiercoles.TabIndex = 6;
            chkMiercoles.Text = "Miercoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkJueves.Location = new Point(277, 143);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(59, 17);
            chkJueves.TabIndex = 7;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkViernes.Location = new Point(342, 143);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(64, 17);
            chkViernes.TabIndex = 8;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(18, 138);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(43, 21);
            lblDias.TabIndex = 9;
            lblDias.Text = "Dias:";
            // 
            // frmAsignacionHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 509);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpHorario);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosTrabajador);
            Controls.Add(grpBuscarTrabajador);
            Name = "frmAsignacionHorarios";
            Text = "frmAsignacionHorarios";
            grpBuscarTrabajador.ResumeLayout(false);
            grpBuscarTrabajador.PerformLayout();
            grpDatosTrabajador.ResumeLayout(false);
            grpDatosTrabajador.PerformLayout();
            grpHorario.ResumeLayout(false);
            grpHorario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBuscarTrabajador;
        private GroupBox grpDatosTrabajador;
        private Label lblTitulo;
        private Button btnBuscar;
        private TextBox txtBusacarClave;
        private Label lblClaveTrabaj;
        private TextBox txtPuesto;
        private TextBox txtDepartamento;
        private TextBox txtSemestre;
        private TextBox txtBuscarNombreCompleto;
        private Label lblPuesto;
        private Label lblDepartamento;
        private Label lblSemestre;
        private Label lblNombreCompleto;
        private GroupBox grpHorario;
        private Button btnGuardar;
        private Button btnCancelar;
        private DateTimePicker dtpHoraSalida;
        private Label lblHoraEntrada;
        private DateTimePicker dtpHoraEntrada;
        private Label lblHoraSalida;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private CheckBox chkLunes;
        private Label lblDias;
    }
}