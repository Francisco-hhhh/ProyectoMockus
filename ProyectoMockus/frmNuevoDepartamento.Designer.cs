namespace ProyectoMockus
{
    partial class frmNuevoDepartamento
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
            lblNuevoDepartamento = new Label();
            pnlDepartamento = new Panel();
            lblDepartamento = new Label();
            txtDepartamento = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            button2 = new Button();
            pnlDepartamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblNuevoDepartamento
            // 
            lblNuevoDepartamento.AutoSize = true;
            lblNuevoDepartamento.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevoDepartamento.Location = new Point(69, 9);
            lblNuevoDepartamento.Name = "lblNuevoDepartamento";
            lblNuevoDepartamento.Size = new Size(226, 30);
            lblNuevoDepartamento.TabIndex = 0;
            lblNuevoDepartamento.Text = "Nuevo Departamento";
            // 
            // pnlDepartamento
            // 
            pnlDepartamento.BorderStyle = BorderStyle.FixedSingle;
            pnlDepartamento.Controls.Add(txtDescripcion);
            pnlDepartamento.Controls.Add(lblDescripcion);
            pnlDepartamento.Controls.Add(txtDepartamento);
            pnlDepartamento.Controls.Add(lblDepartamento);
            pnlDepartamento.Location = new Point(12, 42);
            pnlDepartamento.Name = "pnlDepartamento";
            pnlDepartamento.Size = new Size(320, 177);
            pnlDepartamento.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.Location = new Point(13, 13);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 0;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(13, 37);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(280, 23);
            txtDepartamento.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(13, 63);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(13, 87);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(280, 80);
            txtDescripcion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(12, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 32);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(232, 225);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmNuevoDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 271);
            Controls.Add(button2);
            Controls.Add(btnGuardar);
            Controls.Add(pnlDepartamento);
            Controls.Add(lblNuevoDepartamento);
            Name = "frmNuevoDepartamento";
            Text = "frmNuevoDepartamento";
            pnlDepartamento.ResumeLayout(false);
            pnlDepartamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevoDepartamento;
        private Panel pnlDepartamento;
        private Label lblDescripcion;
        private TextBox txtDepartamento;
        private Label lblDepartamento;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button button2;
    }
}