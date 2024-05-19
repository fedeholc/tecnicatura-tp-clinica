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
            pnlTurnos = new Panel();
            btnVolver = new Button();
            lblTituloT = new Label();
            pnlTituloT = new Panel();
            btnSeleccionarModulo = new Button();
            this.grbMostrarModulos = new GroupBox();
            this.rbtEstudiosClinicos = new RadioButton();
            rbtConsultoriosMedicos = new RadioButton();
            btnSalir = new Button();
            pnlTurnos.SuspendLayout();
            this.grbMostrarModulos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTurnos
            // 
            pnlTurnos.BackgroundImage = (Image)resources.GetObject("pnlTurnos.BackgroundImage");
            pnlTurnos.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnos.Controls.Add(btnVolver);
            pnlTurnos.Controls.Add(lblTituloT);
            pnlTurnos.Controls.Add(pnlTituloT);
            pnlTurnos.Controls.Add(btnSeleccionarModulo);
            pnlTurnos.Controls.Add(this.grbMostrarModulos);
            pnlTurnos.Controls.Add(btnSalir);
            pnlTurnos.Location = new Point(152, 53);
            pnlTurnos.Name = "pnlTurnos";
            pnlTurnos.Size = new Size(1281, 811);
            pnlTurnos.TabIndex = 38;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1032, 554);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 46);
            btnVolver.TabIndex = 36;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
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
            // 
            // grbMostrarModulos
            // 
            this.grbMostrarModulos.BackColor = Color.Transparent;
            this.grbMostrarModulos.Controls.Add(this.rbtEstudiosClinicos);
            this.grbMostrarModulos.Controls.Add(rbtConsultoriosMedicos);
            this.grbMostrarModulos.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            this.grbMostrarModulos.Location = new Point(212, 163);
            this.grbMostrarModulos.Margin = new Padding(3, 4, 3, 4);
            this.grbMostrarModulos.Name = "grbMostrarModulos";
            this.grbMostrarModulos.Padding = new Padding(3, 4, 3, 4);
            this.grbMostrarModulos.Size = new Size(397, 284);
            this.grbMostrarModulos.TabIndex = 26;
            this.grbMostrarModulos.TabStop = false;
            this.grbMostrarModulos.Text = "Mostrar Módulos";
            // 
            // rbtEstudiosClinicos
            // 
            this.rbtEstudiosClinicos.AutoSize = true;
            this.rbtEstudiosClinicos.Location = new Point(24, 181);
            this.rbtEstudiosClinicos.Margin = new Padding(3, 4, 3, 4);
            this.rbtEstudiosClinicos.Name = "rbtEstudiosClinicos";
            this.rbtEstudiosClinicos.Size = new Size(217, 36);
            this.rbtEstudiosClinicos.TabIndex = 1;
            this.rbtEstudiosClinicos.Text = "Estudios Clínicos";
            this.rbtEstudiosClinicos.UseVisualStyleBackColor = true;
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
            // 
            // frmModulos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 889);
            Controls.Add(pnlTurnos);
            Name = "frmModulos";
            Text = "frmModulos";
            pnlTurnos.ResumeLayout(false);
            pnlTurnos.PerformLayout();
            this.grbMostrarModulos.ResumeLayout(false);
            this.grbMostrarModulos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTurnos;
        private Button btnVolver;
        private Label lblTituloT;
        private Panel pnlTituloT;
        private Button btnAsignar;
        private Button btnCancelar;
        private Button btnSeleccionarModulo;
        private GroupBox grbMostrarTurnos;
        private RadioButton rbtOcupados;
        private RadioButton rbtConsultoriosMedicos;
        private Button btnSalir;
    }
}