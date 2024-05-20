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
            btnSeleccionarModulo = new Button();
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
            pnlModulos.Controls.Add(btnSeleccionarModulo);
            pnlModulos.Controls.Add(btnSalir);
            pnlModulos.Location = new Point(152, 53);
            pnlModulos.Name = "pnlModulos";
            pnlModulos.Size = new Size(1281, 811);
            pnlModulos.TabIndex = 38;
            // 
            // grbSeleccionarModulos
            // 
            grbSeleccionarModulos.BackColor = Color.Transparent;
            grbSeleccionarModulos.Controls.Add(rbtEstudiosClinic);
            grbSeleccionarModulos.Controls.Add(rbtConsultoriosMed);
            grbSeleccionarModulos.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSeleccionarModulos.Location = new Point(211, 178);
            grbSeleccionarModulos.Margin = new Padding(3, 4, 3, 4);
            grbSeleccionarModulos.Name = "grbSeleccionarModulos";
            grbSeleccionarModulos.Padding = new Padding(3, 4, 3, 4);
            grbSeleccionarModulos.Size = new Size(318, 268);
            grbSeleccionarModulos.TabIndex = 38;
            grbSeleccionarModulos.TabStop = false;
            grbSeleccionarModulos.Text = "Seleccionar Modulo";
            // 
            // rbtEstudiosClinic
            // 
            rbtEstudiosClinic.AutoSize = true;
            rbtEstudiosClinic.Location = new Point(24, 142);
            rbtEstudiosClinic.Margin = new Padding(3, 4, 3, 4);
            rbtEstudiosClinic.Name = "rbtEstudiosClinic";
            rbtEstudiosClinic.Size = new Size(217, 36);
            rbtEstudiosClinic.TabIndex = 1;
            rbtEstudiosClinic.Text = "Estudios Clínicos";
            rbtEstudiosClinic.UseVisualStyleBackColor = true;
            // 
            // rbtConsultoriosMed
            // 
            rbtConsultoriosMed.AutoSize = true;
            rbtConsultoriosMed.Checked = true;
            rbtConsultoriosMed.Location = new Point(24, 50);
            rbtConsultoriosMed.Margin = new Padding(3, 4, 3, 4);
            rbtConsultoriosMed.Name = "rbtConsultoriosMed";
            rbtConsultoriosMed.Size = new Size(267, 36);
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
            lblTituloT.Location = new Point(211, 35);
            lblTituloT.Name = "lblTituloT";
            lblTituloT.Size = new Size(360, 46);
            lblTituloT.TabIndex = 33;
            lblTituloT.Text = "Selección de Módulos";
            // 
            // pnlTituloT
            // 
            pnlTituloT.BorderStyle = BorderStyle.FixedSingle;
            pnlTituloT.ForeColor = SystemColors.ActiveBorder;
            pnlTituloT.Location = new Point(211, 65);
            pnlTituloT.Margin = new Padding(3, 4, 3, 4);
            pnlTituloT.Name = "pnlTituloT";
            pnlTituloT.Size = new Size(962, 1);
            pnlTituloT.TabIndex = 29;
            // 
            // btnSeleccionarModulo
            // 
            btnSeleccionarModulo.FlatAppearance.BorderColor = Color.LightGray;
            btnSeleccionarModulo.FlatStyle = FlatStyle.Flat;
            btnSeleccionarModulo.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSeleccionarModulo.Location = new Point(349, 492);
            btnSeleccionarModulo.Margin = new Padding(3, 4, 3, 4);
            btnSeleccionarModulo.Name = "btnSeleccionarModulo";
            btnSeleccionarModulo.Size = new Size(180, 55);
            btnSeleccionarModulo.TabIndex = 30;
            btnSeleccionarModulo.Text = "Seleccionar";
            btnSeleccionarModulo.UseVisualStyleBackColor = true;
            btnSeleccionarModulo.Click += btnSeleccionarModulo_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1084, 19);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 47);
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 889);
            Controls.Add(pnlModulos);
            Name = "frmModulos";
            Text = "frmModulos";
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
        private Button btnSeleccionarModulo;

        public GroupBox grbMostrarModulos { get; private set; }
        public RadioButton rbtEstudiosClinicos { get; private set; }

        private GroupBox grbSeleccionarModulos;
        private RadioButton rbtEstudiosClinic;
        private RadioButton rbtConsultoriosMedicos;
        private Button btnSalir;
        private RadioButton rbtConsultoriosMed;
    }
}