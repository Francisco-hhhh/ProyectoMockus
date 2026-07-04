namespace ProyectoMockus
{
    partial class frmNuevoPuesto
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbDepartemento = new ComboBox();
            lblTitulo = new Label();
            txtNombrePuesto = new TextBox();
            lblNombrePuesto = new Label();
            lblDepartamento = new Label();
            pnlPuesto = new Panel();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(40, 223);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 32);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDarkDark;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(200, 223);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbDepartemento
            // 
            cmbDepartemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartemento.FormattingEnabled = true;
            cmbDepartemento.Location = new Point(40, 167);
            cmbDepartemento.Name = "cmbDepartemento";
            cmbDepartemento.Size = new Size(260, 29);
            cmbDepartemento.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(106, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(151, 30);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Nuevo Puesto";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.AccessibleName = "x";
            txtNombrePuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePuesto.Location = new Point(40, 111);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(260, 29);
            txtNombrePuesto.TabIndex = 4;
            // 
            // lblNombrePuesto
            // 
            lblNombrePuesto.AutoSize = true;
            lblNombrePuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePuesto.Location = new Point(40, 87);
            lblNombrePuesto.Name = "lblNombrePuesto";
            lblNombrePuesto.Size = new Size(147, 21);
            lblNombrePuesto.TabIndex = 5;
            lblNombrePuesto.Text = "Nombre del puesto:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.Location = new Point(40, 143);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(231, 21);
            lblDepartamento.TabIndex = 6;
            lblDepartamento.Text = "Departamento al que pertenece:";
            // 
            // pnlPuesto
            // 
            pnlPuesto.BorderStyle = BorderStyle.FixedSingle;
            pnlPuesto.Location = new Point(14, 75);
            pnlPuesto.Name = "pnlPuesto";
            pnlPuesto.Size = new Size(318, 142);
            pnlPuesto.TabIndex = 7;
            // 
            // frmNuevoPuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 291);
            Controls.Add(lblDepartamento);
            Controls.Add(lblNombrePuesto);
            Controls.Add(txtNombrePuesto);
            Controls.Add(lblTitulo);
            Controls.Add(cmbDepartemento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(pnlPuesto);
            Name = "frmNuevoPuesto";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cmbDepartemento;
        private Label lblTitulo;
        private TextBox txtNombrePuesto;
        private Label lblNombrePuesto;
        private Label lblDepartamento;
        private Panel pnlPuesto;
    }
}
