namespace ProyectoMockus
{
    partial class frmAccesoAdmin
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
            lblAcceso = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnInicio = new Button();
            SuspendLayout();
            // 
            // lblAcceso
            // 
            lblAcceso.AutoSize = true;
            lblAcceso.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcceso.Location = new Point(40, 9);
            lblAcceso.Name = "lblAcceso";
            lblAcceso.Size = new Size(271, 32);
            lblAcceso.TabIndex = 0;
            lblAcceso.Text = "Acceso Administrativo";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(51, 72);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(51, 133);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(100, 21);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(51, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(51, 157);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(260, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.HotTrack;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.Location = new Point(96, 202);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 35);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio Sesion";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // frmAccesoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 274);
            Controls.Add(btnInicio);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblAcceso);
            Name = "frmAccesoAdmin";
            Text = "frmAccesoAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcceso;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnInicio;
    }
}