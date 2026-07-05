namespace Mockups
{
    partial class frmPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            frmContenido = new Panel();
            lblSubtitulo = new Label();
            dgvRegistros = new DataGridView();
            dtpFiltroAsistencia = new DateTimePicker();
            txtClaveTrabajador = new TextBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            lblClaveTrabajador = new Label();
            lblFecha = new Label();
            lblBienvenida = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            frmContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
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
            pnlSidebar.Location = new Point(1, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 728);
            pnlSidebar.TabIndex = 0;
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
            lblSistema.Location = new Point(40, 186);
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
            pcbLogo.Location = new Point(37, 34);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(140, 140);
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // frmContenido
            // 
            frmContenido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            frmContenido.Controls.Add(lblSubtitulo);
            frmContenido.Controls.Add(dgvRegistros);
            frmContenido.Controls.Add(dtpFiltroAsistencia);
            frmContenido.Controls.Add(txtClaveTrabajador);
            frmContenido.Controls.Add(btnLimpiar);
            frmContenido.Controls.Add(btnBuscar);
            frmContenido.Controls.Add(lblClaveTrabajador);
            frmContenido.Controls.Add(lblFecha);
            frmContenido.Controls.Add(lblBienvenida);
            frmContenido.Location = new Point(227, 0);
            frmContenido.Name = "frmContenido";
            frmContenido.Size = new Size(780, 728);
            frmContenido.TabIndex = 1;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(112, 73);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(589, 25);
            lblSubtitulo.TabIndex = 8;
            lblSubtitulo.Text = "Consulte todos los registros de un empleado en una fecha especifica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvRegistros
            // 
            dgvRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(-3, 274);
            dgvRegistros.Name = "dgvRegistros";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.Size = new Size(780, 454);
            dgvRegistros.TabIndex = 7;
            // 
            // dtpFiltroAsistencia
            // 
            dtpFiltroAsistencia.Location = new Point(32, 181);
            dtpFiltroAsistencia.Name = "dtpFiltroAsistencia";
            dtpFiltroAsistencia.Size = new Size(150, 29);
            dtpFiltroAsistencia.TabIndex = 6;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.Location = new Point(217, 181);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(150, 29);
            txtClaveTrabajador.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.HotTrack;
            btnLimpiar.FlatAppearance.BorderColor = Color.White;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(404, 174);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(591, 174);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.BackColor = SystemColors.ScrollBar;
            lblClaveTrabajador.ForeColor = SystemColors.Desktop;
            lblClaveTrabajador.Location = new Point(217, 149);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 2;
            lblClaveTrabajador.Text = "Clave de Trabajador:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.ScrollBar;
            lblFecha.ForeColor = SystemColors.Desktop;
            lblFecha.Location = new Point(32, 149);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBienvenida.BackColor = SystemColors.ScrollBar;
            lblBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.ControlDarkDark;
            lblBienvenida.Location = new Point(175, 25);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(415, 30);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido Administrador: Kevin Solares";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1008, 729);
            Controls.Add(frmContenido);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPrincipal";
            Text = "Administrador";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            frmContenido.ResumeLayout(false);
            frmContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private PictureBox pcbLogo;
        private Button btnEmpleados;
        private Label lblSistema;
        private Button btnIncidencias;
        private Button btnPuestos;
        private Button btnDepartamentos;
        private Button btnHorarios;
        private Button btnCerrarSesion;
        private Button btnReportes;
        private Panel frmContenido;
        private Label lblBienvenida;
        private Label lblFecha;
        private Label lblClaveTrabajador;
        private Button btnLimpiar;
        private Button btnBuscar;
        private TextBox txtClaveTrabajador;
        private DataGridView dgvRegistros;
        private Label lblSubtitulo;
        private DateTimePicker dtpFiltroAsistencia;
    }
}