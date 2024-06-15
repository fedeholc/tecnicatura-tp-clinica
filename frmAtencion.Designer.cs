namespace clinica
{
    partial class frmAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtencion));
            btnVolver = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            label2 = new Label();
            cbxLugar = new ComboBox();
            lbxEnEspera = new ListBox();
            rtxtHistoriaClinica = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            btnRegistrarAtencion = new Button();
            btnPacienteAusente = new Button();
            lblTituloA = new Label();
            pnlAtencion = new Panel();
            btnImprimirComprobante = new Button();
            pnlAtencion.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(775, 550);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(65, 30);
            btnVolver.TabIndex = 45;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(194, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 1);
            panel2.TabIndex = 44;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(780, 33);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
            btnSalir.TabIndex = 43;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(194, 81);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 64;
            label2.Text = "Seleccione lugar de atención";
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(194, 99);
            cbxLugar.Name = "cbxLugar";
            cbxLugar.Size = new Size(234, 23);
            cbxLugar.TabIndex = 63;
            cbxLugar.SelectedIndexChanged += cbxLugar_SelectedIndexChanged;
            // 
            // lbxEnEspera
            // 
            lbxEnEspera.FormattingEnabled = true;
            lbxEnEspera.ItemHeight = 15;
            lbxEnEspera.Location = new Point(194, 165);
            lbxEnEspera.Name = "lbxEnEspera";
            lbxEnEspera.Size = new Size(408, 94);
            lbxEnEspera.TabIndex = 65;
            lbxEnEspera.SelectedIndexChanged += lbxEnEspera_SelectedIndexChanged;
            // 
            // rtxtHistoriaClinica
            // 
            rtxtHistoriaClinica.Location = new Point(194, 294);
            rtxtHistoriaClinica.Name = "rtxtHistoriaClinica";
            rtxtHistoriaClinica.Size = new Size(646, 238);
            rtxtHistoriaClinica.TabIndex = 67;
            rtxtHistoriaClinica.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(194, 147);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 68;
            label1.Text = "Seleccione Paciente de lista de espera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label3.Location = new Point(194, 276);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 69;
            label3.Text = "Historia Clínica del paciente";
            // 
            // btnRegistrarAtencion
            // 
            btnRegistrarAtencion.FlatAppearance.BorderColor = Color.LightGray;
            btnRegistrarAtencion.FlatStyle = FlatStyle.Flat;
            btnRegistrarAtencion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarAtencion.Location = new Point(598, 550);
            btnRegistrarAtencion.Name = "btnRegistrarAtencion";
            btnRegistrarAtencion.Size = new Size(150, 30);
            btnRegistrarAtencion.TabIndex = 70;
            btnRegistrarAtencion.Text = "Paciente Atendido";
            btnRegistrarAtencion.UseVisualStyleBackColor = true;
            btnRegistrarAtencion.Click += btnRegistrarAtencion_Click;
            // 
            // btnPacienteAusente
            // 
            btnPacienteAusente.FlatAppearance.BorderColor = Color.LightGray;
            btnPacienteAusente.FlatStyle = FlatStyle.Flat;
            btnPacienteAusente.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnPacienteAusente.ForeColor = SystemColors.InfoText;
            btnPacienteAusente.Location = new Point(421, 550);
            btnPacienteAusente.Name = "btnPacienteAusente";
            btnPacienteAusente.Size = new Size(150, 30);
            btnPacienteAusente.TabIndex = 71;
            btnPacienteAusente.Text = "Paciente Ausente";
            btnPacienteAusente.UseVisualStyleBackColor = true;
            btnPacienteAusente.Click += btnPacienteAusente_Click;
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(196, 36);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(173, 23);
            lblTituloA.TabIndex = 72;
            lblTituloA.Text = "Registro de Atención";
            // 
            // pnlAtencion
            // 
            pnlAtencion.BackgroundImage = (Image)resources.GetObject("pnlAtencion.BackgroundImage");
            pnlAtencion.BackgroundImageLayout = ImageLayout.Center;
            pnlAtencion.BorderStyle = BorderStyle.FixedSingle;
            pnlAtencion.Controls.Add(btnImprimirComprobante);
            pnlAtencion.Controls.Add(lblTituloA);
            pnlAtencion.Controls.Add(btnPacienteAusente);
            pnlAtencion.Controls.Add(btnRegistrarAtencion);
            pnlAtencion.Controls.Add(label3);
            pnlAtencion.Controls.Add(label1);
            pnlAtencion.Controls.Add(rtxtHistoriaClinica);
            pnlAtencion.Controls.Add(lbxEnEspera);
            pnlAtencion.Controls.Add(label2);
            pnlAtencion.Controls.Add(cbxLugar);
            pnlAtencion.Controls.Add(btnVolver);
            pnlAtencion.Controls.Add(panel2);
            pnlAtencion.Controls.Add(btnSalir);
            pnlAtencion.Location = new Point(12, 12);
            pnlAtencion.Name = "pnlAtencion";
            pnlAtencion.Size = new Size(966, 631);
            pnlAtencion.TabIndex = 73;
            // 
            // btnImprimirComprobante
            // 
            btnImprimirComprobante.FlatAppearance.BorderColor = Color.LightGray;
            btnImprimirComprobante.FlatStyle = FlatStyle.Flat;
            btnImprimirComprobante.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnImprimirComprobante.Location = new Point(196, 550);
            btnImprimirComprobante.Name = "btnImprimirComprobante";
            btnImprimirComprobante.Size = new Size(184, 30);
            btnImprimirComprobante.TabIndex = 73;
            btnImprimirComprobante.Text = "Imprimir Comprobante";
            btnImprimirComprobante.UseVisualStyleBackColor = true;
            btnImprimirComprobante.Click += btnImprimirComprobante_Click;
            // 
            // frmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 654);
            Controls.Add(pnlAtencion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAtencion";
            Text = "frmAtencion";
            Load += frmAtencion_Load;
            pnlAtencion.ResumeLayout(false);
            pnlAtencion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Panel panel2;
        private Button btnSalir;
        private Label label2;
        private ComboBox cbxLugar;
        private ListBox lbxEnEspera;
        private RichTextBox rtxtHistoriaClinica;
        private Label label1;
        private Label label3;
        private Button btnRegistrarAtencion;
        private Button btnPacienteAusente;
        private Label lblTituloA;
        private Panel pnlAtencion;
        private Button btnImprimirComprobante;
    }
}