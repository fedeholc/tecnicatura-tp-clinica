namespace clinica
{
    partial class frmModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModulos));
            pnlModulos = new Panel();
            grbSeleccionarModulos = new GroupBox();
            rbtEstudiosClinic = new RadioButton();
            rbtConsultoriosMed = new RadioButton();
            lblTituloT = new Label();
            pnlTituloT = new Panel();
            btnIngresarModulo = new Button();
            btnSalir = new Button();
            rbtConsultoriosMedicos = new RadioButton();
            pnlModulos.SuspendLayout();
            grbSeleccionarModulos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlModulos
            // 
            pnlModulos.BackgroundImage = (Image)resources.GetObject("pnlModulos.BackgroundImage");
            pnlModulos.BorderStyle = BorderStyle.FixedSingle;
            pnlModulos.Controls.Add(grbSeleccionarModulos);
            pnlModulos.Controls.Add(lblTituloT);
            pnlModulos.Controls.Add(pnlTituloT);
            pnlModulos.Controls.Add(btnIngresarModulo);
            pnlModulos.Controls.Add(btnSalir);
            pnlModulos.Location = new Point(11, 10);
            pnlModulos.Margin = new Padding(2, 1, 2, 1);
            pnlModulos.Name = "pnlModulos";
            pnlModulos.Size = new Size(518, 216);
            pnlModulos.TabIndex = 38;
            // 
            // grbSeleccionarModulos
            // 
            grbSeleccionarModulos.BackColor = Color.Transparent;
            grbSeleccionarModulos.Controls.Add(rbtEstudiosClinic);
            grbSeleccionarModulos.Controls.Add(rbtConsultoriosMed);
            grbSeleccionarModulos.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSeleccionarModulos.Location = new Point(147, 72);
            grbSeleccionarModulos.Margin = new Padding(2);
            grbSeleccionarModulos.Name = "grbSeleccionarModulos";
            grbSeleccionarModulos.Padding = new Padding(2);
            grbSeleccionarModulos.Size = new Size(171, 101);
            grbSeleccionarModulos.TabIndex = 38;
            grbSeleccionarModulos.TabStop = false;
            grbSeleccionarModulos.Text = "Seleccionar Módulo";
            // 
            // rbtEstudiosClinic
            // 
            rbtEstudiosClinic.AutoSize = true;
            rbtEstudiosClinic.Location = new Point(13, 67);
            rbtEstudiosClinic.Margin = new Padding(2);
            rbtEstudiosClinic.Name = "rbtEstudiosClinic";
            rbtEstudiosClinic.Size = new Size(112, 19);
            rbtEstudiosClinic.TabIndex = 1;
            rbtEstudiosClinic.Text = "Estudios Clínicos";
            rbtEstudiosClinic.UseVisualStyleBackColor = true;
            // 
            // rbtConsultoriosMed
            // 
            rbtConsultoriosMed.AutoSize = true;
            rbtConsultoriosMed.Checked = true;
            rbtConsultoriosMed.Location = new Point(13, 23);
            rbtConsultoriosMed.Margin = new Padding(2);
            rbtConsultoriosMed.Name = "rbtConsultoriosMed";
            rbtConsultoriosMed.Size = new Size(138, 19);
            rbtConsultoriosMed.TabIndex = 0;
            rbtConsultoriosMed.TabStop = true;
            rbtConsultoriosMed.Text = "Consultorios Médicos";
            rbtConsultoriosMed.UseVisualStyleBackColor = true;
            // 
            // lblTituloT
            // 
            lblTituloT.AutoSize = true;
            lblTituloT.BackColor = Color.Transparent;
            lblTituloT.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloT.Location = new Point(147, 26);
            lblTituloT.Margin = new Padding(2, 0, 2, 0);
            lblTituloT.Name = "lblTituloT";
            lblTituloT.Size = new Size(179, 23);
            lblTituloT.TabIndex = 33;
            lblTituloT.Text = "Selección de Módulos";
            // 
            // pnlTituloT
            // 
            pnlTituloT.BorderStyle = BorderStyle.FixedSingle;
            pnlTituloT.ForeColor = SystemColors.ActiveBorder;
            pnlTituloT.Location = new Point(147, 51);
            pnlTituloT.Margin = new Padding(2);
            pnlTituloT.Name = "pnlTituloT";
            pnlTituloT.Size = new Size(331, 2);
            pnlTituloT.TabIndex = 29;
            // 
            // btnIngresarModulo
            // 
            btnIngresarModulo.FlatAppearance.BorderColor = Color.LightGray;
            btnIngresarModulo.FlatStyle = FlatStyle.Flat;
            btnIngresarModulo.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnIngresarModulo.Location = new Point(375, 141);
            btnIngresarModulo.Margin = new Padding(2);
            btnIngresarModulo.Name = "btnIngresarModulo";
            btnIngresarModulo.Size = new Size(103, 32);
            btnIngresarModulo.TabIndex = 30;
            btnIngresarModulo.Text = "Ingresar";
            btnIngresarModulo.UseVisualStyleBackColor = true;
            btnIngresarModulo.Click += btnIngresarModulo_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(418, 19);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rbtConsultoriosMedicos
            // 
            rbtConsultoriosMedicos.AutoSize = true;
            rbtConsultoriosMedicos.Checked = true;
            rbtConsultoriosMedicos.Location = new Point(24, 77);
            rbtConsultoriosMedicos.Margin = new Padding(3, 4, 3, 4);
            rbtConsultoriosMedicos.Name = "rbtConsultoriosMedicos";
            rbtConsultoriosMedicos.Size = new Size(267, 36);
            rbtConsultoriosMedicos.TabIndex = 0;
            rbtConsultoriosMedicos.TabStop = true;
            rbtConsultoriosMedicos.Text = "Consultorios Médicos";
            rbtConsultoriosMedicos.UseVisualStyleBackColor = true;
            // 
            // frmModulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 244);
            Controls.Add(pnlModulos);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmModulos";
            Text = "Módulos";
            pnlModulos.ResumeLayout(false);
            pnlModulos.PerformLayout();
            grbSeleccionarModulos.ResumeLayout(false);
            grbSeleccionarModulos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlModulos;
        private Label lblTituloT;
        private Panel pnlTituloT;
        private Button btnAsignar;
        private Button btnCancelar;
        private Button btnIngresarModulo;

        public GroupBox grbMostrarModulos { get; private set; }
        public RadioButton rbtEstudiosClinicos { get; private set; }

        private GroupBox grbSeleccionarModulos;
        private RadioButton rbtEstudiosClinic;
        private RadioButton rbtConsultoriosMedicos;
        private Button btnSalir;
        private RadioButton rbtConsultoriosMed;
    }
}