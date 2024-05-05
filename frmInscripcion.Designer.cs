namespace Clinica
{
    partial class frmInscripcion
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblCobertura = new Label();
            btnInscribir = new Button();
            btnVolver = new Button();
            panel1 = new Panel();
            cbxCobertura = new ComboBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            labelApellido = new Label();
            txtApellido = new TextBox();
            btnNuevaInscripcion = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(17, 101);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 3;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(17, 83);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // lblCobertura
            // 
            lblCobertura.AutoSize = true;
            lblCobertura.Location = new Point(251, 150);
            lblCobertura.Name = "lblCobertura";
            lblCobertura.Size = new Size(60, 15);
            lblCobertura.TabIndex = 7;
            lblCobertura.Text = "Cobertura";
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnInscribir.Location = new Point(363, 263);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(97, 32);
            btnInscribir.TabIndex = 13;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(435, 346);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 23);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbxCobertura);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(labelApellido);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(btnInscribir);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblCobertura);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(30, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 315);
            panel1.TabIndex = 16;
            // 
            // cbxCobertura
            // 
            cbxCobertura.FormattingEnabled = true;
            cbxCobertura.Location = new Point(251, 168);
            cbxCobertura.Name = "cbxCobertura";
            cbxCobertura.Size = new Size(209, 23);
            cbxCobertura.TabIndex = 19;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(251, 83);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(251, 101);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(209, 23);
            txtDireccion.TabIndex = 18;
            txtDireccion.TextChanged += textBox1_TextChanged;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(251, 20);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 15;
            labelApellido.Text = "Apellido";
            labelApellido.Click += label1_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(251, 38);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(209, 23);
            txtApellido.TabIndex = 16;
            // 
            // btnNuevaInscripcion
            // 
            btnNuevaInscripcion.Location = new Point(309, 346);
            btnNuevaInscripcion.Name = "btnNuevaInscripcion";
            btnNuevaInscripcion.Size = new Size(120, 23);
            btnNuevaInscripcion.TabIndex = 17;
            btnNuevaInscripcion.Text = "Nueva Inscripción";
            btnNuevaInscripcion.UseVisualStyleBackColor = true;
            btnNuevaInscripcion.Click += btnNuevaInscripcion_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 392);
            Controls.Add(btnNuevaInscripcion);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Inscripción";
            Load += frmInscripcion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCobertura;
        private Button btnInscribir;
        private Button btnVolver;
        private Panel panel1;
        private Button btnNuevaInscripcion;
        private Label labelApellido;
        private TextBox txtApellido;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private ComboBox cbxCobertura;
    }
}