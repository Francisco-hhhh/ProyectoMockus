namespace ProyectoMockus
{
    partial class frmIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidencias));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnCerrarSesion = new Button();
            btnReportes = new Button();
            btnIncidencias = new Button();
            btnPuestos = new Button();
            btnEmpleados = new Button();
            btnDepartamentos = new Button();
            lblSistema = new Label();
            btnHorarios = new Button();
            pcbLogo = new PictureBox();
            frmIncidencia = new Panel();
            dgvPuestos = new DataGridView();
            btnBuscar = new Button();
            btnJustificar = new Button();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            dtpFecha = new DateTimePicker();
            txtClaveTrabajador = new TextBox();
            lblClaveTrabajador = new Label();
            lblFecha = new Label();
            cmbTipoIncidencia = new ComboBox();
            lblTipoIncidencia = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            frmIncidencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSidebar.BackColor = Color.SteelBlue;
            pnlSidebar.Controls.Add(btnCerrarSesion);
            pnlSidebar.Controls.Add(btnReportes);
            pnlSidebar.Controls.Add(btnIncidencias);
            pnlSidebar.Controls.Add(btnPuestos);
            pnlSidebar.Controls.Add(btnEmpleados);
            pnlSidebar.Controls.Add(btnDepartamentos);
            pnlSidebar.Controls.Add(lblSistema);
            pnlSidebar.Controls.Add(btnHorarios);
            pnlSidebar.Controls.Add(pcbLogo);
            pnlSidebar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 728);
            pnlSidebar.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.ControlDarkDark;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.White;
            btnCerrarSesion.FlatAppearance.BorderSize = 2;
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Location = new Point(15, 571);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(185, 40);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "CerrarSesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.HotTrack;
            btnReportes.FlatAppearance.BorderColor = Color.White;
            btnReportes.FlatAppearance.BorderSize = 2;
            btnReportes.ForeColor = SystemColors.ControlLightLight;
            btnReportes.Location = new Point(15, 511);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(185, 40);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnIncidencias
            // 
            btnIncidencias.BackColor = SystemColors.HotTrack;
            btnIncidencias.FlatAppearance.BorderColor = Color.White;
            btnIncidencias.FlatAppearance.BorderSize = 2;
            btnIncidencias.ForeColor = SystemColors.ControlLightLight;
            btnIncidencias.Location = new Point(15, 454);
            btnIncidencias.Name = "btnIncidencias";
            btnIncidencias.Size = new Size(185, 40);
            btnIncidencias.TabIndex = 5;
            btnIncidencias.Text = "Incidencias";
            btnIncidencias.UseVisualStyleBackColor = false;
            // 
            // btnPuestos
            // 
            btnPuestos.BackColor = SystemColors.HotTrack;
            btnPuestos.FlatAppearance.BorderColor = Color.White;
            btnPuestos.FlatAppearance.BorderSize = 2;
            btnPuestos.ForeColor = SystemColors.ControlLightLight;
            btnPuestos.Location = new Point(15, 395);
            btnPuestos.Name = "btnPuestos";
            btnPuestos.Size = new Size(185, 40);
            btnPuestos.TabIndex = 4;
            btnPuestos.Text = "Puestos";
            btnPuestos.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = SystemColors.HotTrack;
            btnEmpleados.FlatAppearance.BorderColor = Color.White;
            btnEmpleados.FlatAppearance.BorderSize = 2;
            btnEmpleados.ForeColor = SystemColors.ControlLightLight;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(15, 226);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(185, 40);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.BackColor = SystemColors.HotTrack;
            btnDepartamentos.FlatAppearance.BorderColor = Color.White;
            btnDepartamentos.FlatAppearance.BorderSize = 2;
            btnDepartamentos.ForeColor = SystemColors.ControlLightLight;
            btnDepartamentos.Location = new Point(15, 338);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(185, 40);
            btnDepartamentos.TabIndex = 3;
            btnDepartamentos.Text = "Departamentos";
            btnDepartamentos.UseVisualStyleBackColor = false;
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = SystemColors.ControlLightLight;
            lblSistema.Location = new Point(40, 174);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(129, 23);
            lblSistema.TabIndex = 1;
            lblSistema.Text = "Staft Asistence";
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = SystemColors.HotTrack;
            btnHorarios.FlatAppearance.BorderColor = Color.White;
            btnHorarios.FlatAppearance.BorderSize = 2;
            btnHorarios.ForeColor = SystemColors.ControlLightLight;
            btnHorarios.Location = new Point(15, 283);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(185, 40);
            btnHorarios.TabIndex = 2;
            btnHorarios.Text = "Horarios";
            btnHorarios.UseVisualStyleBackColor = false;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(29, 11);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(162, 140);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // frmIncidencia
            // 
            frmIncidencia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            frmIncidencia.Controls.Add(cmbTipoIncidencia);
            frmIncidencia.Controls.Add(lblTipoIncidencia);
            frmIncidencia.Controls.Add(dtpFecha);
            frmIncidencia.Controls.Add(txtClaveTrabajador);
            frmIncidencia.Controls.Add(lblClaveTrabajador);
            frmIncidencia.Controls.Add(lblFecha);
            frmIncidencia.Controls.Add(dgvPuestos);
            frmIncidencia.Controls.Add(btnBuscar);
            frmIncidencia.Controls.Add(btnJustificar);
            frmIncidencia.Controls.Add(lblSubtitulo);
            frmIncidencia.Controls.Add(lblTitulo);
            frmIncidencia.Location = new Point(226, 0);
            frmIncidencia.Name = "frmIncidencia";
            frmIncidencia.Size = new Size(780, 728);
            frmIncidencia.TabIndex = 6;
            // 
            // dgvPuestos
            // 
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(3, 225);
            dgvPuestos.Name = "dgvPuestos";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPuestos.Size = new Size(780, 454);
            dgvPuestos.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(597, 165);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnJustificar
            // 
            btnJustificar.BackColor = SystemColors.HotTrack;
            btnJustificar.FlatAppearance.BorderColor = Color.White;
            btnJustificar.FlatAppearance.BorderSize = 2;
            btnJustificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJustificar.ForeColor = SystemColors.ControlLightLight;
            btnJustificar.Location = new Point(597, 685);
            btnJustificar.Name = "btnJustificar";
            btnJustificar.Size = new Size(180, 40);
            btnJustificar.TabIndex = 14;
            btnJustificar.Text = "Justificar";
            btnJustificar.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.ControlDarkDark;
            lblSubtitulo.Location = new Point(146, 72);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(557, 25);
            lblSubtitulo.TabIndex = 9;
            lblSubtitulo.Text = "Consulte las incidencias de un empleado en una fecha especifica";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ScrollBar;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(344, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(159, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Incidencias";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(0, 176);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 29);
            dtpFecha.TabIndex = 23;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.Location = new Point(185, 176);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(150, 29);
            txtClaveTrabajador.TabIndex = 22;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.BackColor = SystemColors.ScrollBar;
            lblClaveTrabajador.ForeColor = SystemColors.Desktop;
            lblClaveTrabajador.Location = new Point(185, 144);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 21;
            lblClaveTrabajador.Text = "Clave de Trabajador:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.ScrollBar;
            lblFecha.ForeColor = SystemColors.Desktop;
            lblFecha.Location = new Point(0, 144);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "Fecha:";
            // 
            // cmbTipoIncidencia
            // 
            cmbTipoIncidencia.FormattingEnabled = true;
            cmbTipoIncidencia.Location = new Point(353, 175);
            cmbTipoIncidencia.Name = "cmbTipoIncidencia";
            cmbTipoIncidencia.Size = new Size(200, 29);
            cmbTipoIncidencia.TabIndex = 25;
            // 
            // lblTipoIncidencia
            // 
            lblTipoIncidencia.AutoSize = true;
            lblTipoIncidencia.BackColor = SystemColors.ScrollBar;
            lblTipoIncidencia.ForeColor = SystemColors.Desktop;
            lblTipoIncidencia.Location = new Point(353, 144);
            lblTipoIncidencia.Name = "lblTipoIncidencia";
            lblTipoIncidencia.Size = new Size(137, 21);
            lblTipoIncidencia.TabIndex = 24;
            lblTipoIncidencia.Text = "Tipo de Incidencia:";
            // 
            // frmIncidencias
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1008, 729);
            Controls.Add(frmIncidencia);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmIncidencias";
            Text = "frmIncidencias";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            frmIncidencia.ResumeLayout(false);
            frmIncidencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnCerrarSesion;
        private Button btnReportes;
        private Button btnIncidencias;
        private Button btnPuestos;
        private Button btnEmpleados;
        private Button btnDepartamentos;
        private Label lblSistema;
        private Button btnHorarios;
        private PictureBox pcbLogo;
        private Panel frmIncidencia;
        private DataGridView dgvPuestos;
        private Button btnBuscar;
        private Button btnJustificar;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private DateTimePicker dtpFecha;
        private TextBox txtClaveTrabajador;
        private Label lblClaveTrabajador;
        private Label lblFecha;
        private ComboBox cmbTipoIncidencia;
        private Label lblTipoIncidencia;
    }
}