namespace clinica
{
    partial class frmMenuPrincipalConsultorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipalConsultorios));
            pnlPanelPrincipal = new Panel();
            btnVolver = new Button();
            btnAtencion = new Button();
            btnSalir = new Button();
            btnSalaDeEspera = new Button();
            btnAcreditacion = new Button();
            btnTurnos = new Button();
            btnInscripciones = new Button();
            lblIngreso = new Label();
            lblConsultoriosExternos = new Label();
            pnlPanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPanelPrincipal
            // 
            pnlPanelPrincipal.BackgroundImage = (Image)resources.GetObject("pnlPanelPrincipal.BackgroundImage");
            pnlPanelPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPanelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPanelPrincipal.Controls.Add(btnVolver);
            pnlPanelPrincipal.Controls.Add(btnAtencion);
            pnlPanelPrincipal.Controls.Add(btnSalir);
            pnlPanelPrincipal.Controls.Add(btnSalaDeEspera);
            pnlPanelPrincipal.Controls.Add(btnAcreditacion);
            pnlPanelPrincipal.Controls.Add(btnTurnos);
            pnlPanelPrincipal.Controls.Add(btnInscripciones);
            pnlPanelPrincipal.Location = new Point(136, 152);
            pnlPanelPrincipal.Margin = new Padding(6, 6, 6, 6);
            pnlPanelPrincipal.Name = "pnlPanelPrincipal";
            pnlPanelPrincipal.Size = new Size(1062, 724);
            pnlPanelPrincipal.TabIndex = 8;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(907, 662);
            btnVolver.Margin = new Padding(6, 6, 6, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(136, 61);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAtencion
            // 
            btnAtencion.FlatAppearance.BorderColor = Color.LightGray;
            btnAtencion.FlatAppearance.BorderSize = 2;
            btnAtencion.FlatStyle = FlatStyle.Flat;
            btnAtencion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtencion.Location = new Point(748, 523);
            btnAtencion.Margin = new Padding(6, 6, 6, 6);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(205, 64);
            btnAtencion.TabIndex = 10;
            btnAtencion.Text = "Atención";
            btnAtencion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(942, 6);
            btnSalir.Margin = new Padding(6, 6, 6, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 61);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSalaDeEspera
            // 
            btnSalaDeEspera.FlatAppearance.BorderColor = Color.LightGray;
            btnSalaDeEspera.FlatAppearance.BorderSize = 2;
            btnSalaDeEspera.FlatStyle = FlatStyle.Flat;
            btnSalaDeEspera.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalaDeEspera.Location = new Point(419, 619);
            btnSalaDeEspera.Margin = new Padding(6, 6, 6, 6);
            btnSalaDeEspera.Name = "btnSalaDeEspera";
            btnSalaDeEspera.Size = new Size(223, 64);
            btnSalaDeEspera.TabIndex = 9;
            btnSalaDeEspera.Text = "Sala de Espera";
            btnSalaDeEspera.UseVisualStyleBackColor = true;
            // 
            // btnAcreditacion
            // 
            btnAcreditacion.FlatAppearance.BorderColor = Color.LightGray;
            btnAcreditacion.FlatAppearance.BorderSize = 2;
            btnAcreditacion.FlatStyle = FlatStyle.Flat;
            btnAcreditacion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAcreditacion.Location = new Point(533, 523);
            btnAcreditacion.Margin = new Padding(6, 6, 6, 6);
            btnAcreditacion.Name = "btnAcreditacion";
            btnAcreditacion.Size = new Size(205, 64);
            btnAcreditacion.TabIndex = 8;
            btnAcreditacion.Text = "Acreditación";
            btnAcreditacion.UseVisualStyleBackColor = true;
            btnAcreditacion.Click += btnAcreditacion_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderColor = Color.LightGray;
            btnTurnos.FlatAppearance.BorderSize = 2;
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTurnos.Location = new Point(102, 523);
            btnTurnos.Margin = new Padding(6, 6, 6, 6);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(205, 64);
            btnTurnos.TabIndex = 7;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.FlatAppearance.BorderColor = Color.LightGray;
            btnInscripciones.FlatAppearance.BorderSize = 2;
            btnInscripciones.FlatStyle = FlatStyle.Flat;
            btnInscripciones.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInscripciones.Location = new Point(318, 523);
            btnInscripciones.Margin = new Padding(6, 6, 6, 6);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(205, 64);
            btnInscripciones.TabIndex = 2;
            btnInscripciones.Text = "Registro ";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(136, 22);
            lblIngreso.Margin = new Padding(6, 0, 6, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(99, 32);
            lblIngreso.TabIndex = 7;
            lblIngreso.Text = "Usuario:";
            // 
            // lblConsultoriosExternos
            // 
            lblConsultoriosExternos.AutoSize = true;
            lblConsultoriosExternos.Location = new Point(136, 80);
            lblConsultoriosExternos.Margin = new Padding(6, 0, 6, 0);
            lblConsultoriosExternos.Name = "lblConsultoriosExternos";
            lblConsultoriosExternos.Size = new Size(340, 32);
            lblConsultoriosExternos.TabIndex = 9;
            lblConsultoriosExternos.Text = "Modulo: Consultorios Médicos";
            // 
            // frmMenuPrincipalConsultorios
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 928);
            Controls.Add(lblConsultoriosExternos);
            Controls.Add(pnlPanelPrincipal);
            Controls.Add(lblIngreso);
            Name = "frmMenuPrincipalConsultorios";
            Text = "frmMenuPrincipalConsultorios";
            
            pnlPanelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPanelPrincipal;
        private Button btnAtencion;
        private Button btnSalir;
        private Button btnSalaDeEspera;
        private Button btnAcreditacion;
        private Button btnTurnos;
        private Button btnInscripciones;
        private Label lblIngreso;
        private Label lblConsultoriosExternos;
        private Button btnVolver;
    }
}