namespace clinica
{
    partial class frmAcreditacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcreditacion));
            btnVolver = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            btnRegistrarPaciente = new Button();
            label3 = new Label();
            cbxPaciente = new ComboBox();
            lblEstudio = new Label();
            cbxEstudios = new ComboBox();
            lbxTurnos = new ListBox();
            label1 = new Label();
            label4 = new Label();
            lblCoberturaPaciente = new Label();
            lblTituloA = new Label();
            lblMonto = new Label();
            label7 = new Label();
            lblMedioPago = new Label();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            panel1 = new Panel();
            panel3 = new Panel();
            lblRegistroPago = new Label();
            rbtPagado = new RadioButton();
            rbtAdeudado = new RadioButton();
            btnAcreditar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            cbxLugar = new ComboBox();
            rbtNormal = new RadioButton();
            rbtUrgencia = new RadioButton();
            groupBox2 = new GroupBox();
            btnNuevaAcreditacion = new Button();
            pnlAcreditacion = new Panel();
            btnImprimirComprobante = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlAcreditacion.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(669, 542);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(65, 30);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(206, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 1);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(674, 46);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.FlatAppearance.BorderColor = Color.LightGray;
            btnRegistrarPaciente.FlatStyle = FlatStyle.Flat;
            btnRegistrarPaciente.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarPaciente.Location = new Point(584, 111);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(150, 30);
            btnRegistrarPaciente.TabIndex = 42;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label3.Location = new Point(206, 115);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 41;
            label3.Text = "Seleccione Paciente";
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(327, 111);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(234, 23);
            cbxPaciente.TabIndex = 40;
            cbxPaciente.SelectedIndexChanged += cbxPaciente_SelectedIndexChanged;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.BackColor = Color.Transparent;
            lblEstudio.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEstudio.Location = new Point(206, 150);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(98, 15);
            lblEstudio.TabIndex = 44;
            lblEstudio.Text = "Estudio a realizar";
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(327, 147);
            cbxEstudios.Name = "cbxEstudios";
            cbxEstudios.Size = new Size(233, 23);
            cbxEstudios.TabIndex = 43;
            cbxEstudios.SelectedIndexChanged += cbxEstudios_SelectedIndexChanged;
            // 
            // lbxTurnos
            // 
            lbxTurnos.Font = new Font("Segoe UI", 9.75F);
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 17;
            lbxTurnos.Location = new Point(206, 203);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(527, 72);
            lbxTurnos.TabIndex = 45;
            lbxTurnos.SelectedIndexChanged += lbxTurnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(206, 185);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 46;
            label1.Text = "Turnos del paciente seleccionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label4.Location = new Point(6, 31);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 48;
            label4.Text = "Cobertura médica:";
            // 
            // lblCoberturaPaciente
            // 
            lblCoberturaPaciente.AutoSize = true;
            lblCoberturaPaciente.BackColor = SystemColors.ControlLightLight;
            lblCoberturaPaciente.BorderStyle = BorderStyle.FixedSingle;
            lblCoberturaPaciente.Location = new Point(114, 28);
            lblCoberturaPaciente.MaximumSize = new Size(150, 0);
            lblCoberturaPaciente.MinimumSize = new Size(150, 0);
            lblCoberturaPaciente.Name = "lblCoberturaPaciente";
            lblCoberturaPaciente.Padding = new Padding(2);
            lblCoberturaPaciente.Size = new Size(150, 21);
            lblCoberturaPaciente.TabIndex = 49;
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(206, 56);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(213, 23);
            lblTituloA.TabIndex = 50;
            lblTituloA.Text = "Acreditación de Pacientes";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = SystemColors.ControlLightLight;
            lblMonto.BorderStyle = BorderStyle.FixedSingle;
            lblMonto.Location = new Point(367, 28);
            lblMonto.MaximumSize = new Size(150, 0);
            lblMonto.MinimumSize = new Size(50, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Padding = new Padding(2);
            lblMonto.Size = new Size(50, 21);
            lblMonto.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label7.Location = new Point(278, 31);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 51;
            label7.Text = "Monto a pagar:";
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Location = new Point(3, 5);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(91, 15);
            lblMedioPago.TabIndex = 53;
            lblMedioPago.Text = "Medio de pago:";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(100, 3);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(66, 19);
            rbtEfectivo.TabIndex = 54;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(173, 3);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(61, 19);
            rbtTarjeta.TabIndex = 55;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMedioPago);
            panel1.Controls.Add(rbtTarjeta);
            panel1.Controls.Add(rbtEfectivo);
            panel1.Location = new Point(5, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 25);
            panel1.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblRegistroPago);
            panel3.Controls.Add(rbtPagado);
            panel3.Controls.Add(rbtAdeudado);
            panel3.Location = new Point(276, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 29);
            panel3.TabIndex = 57;
            // 
            // lblRegistroPago
            // 
            lblRegistroPago.AutoSize = true;
            lblRegistroPago.Location = new Point(3, 7);
            lblRegistroPago.Name = "lblRegistroPago";
            lblRegistroPago.Size = new Size(89, 15);
            lblRegistroPago.TabIndex = 53;
            lblRegistroPago.Text = "Registrar cómo:";
            // 
            // rbtPagado
            // 
            rbtPagado.AutoSize = true;
            rbtPagado.Location = new Point(98, 5);
            rbtPagado.Name = "rbtPagado";
            rbtPagado.Size = new Size(67, 19);
            rbtPagado.TabIndex = 55;
            rbtPagado.TabStop = true;
            rbtPagado.Text = "Pagado";
            rbtPagado.UseVisualStyleBackColor = true;
            // 
            // rbtAdeudado
            // 
            rbtAdeudado.AutoSize = true;
            rbtAdeudado.Location = new Point(164, 5);
            rbtAdeudado.Name = "rbtAdeudado";
            rbtAdeudado.Size = new Size(80, 19);
            rbtAdeudado.TabIndex = 54;
            rbtAdeudado.TabStop = true;
            rbtAdeudado.Text = "Adeudado";
            rbtAdeudado.UseVisualStyleBackColor = true;
            // 
            // btnAcreditar
            // 
            btnAcreditar.FlatAppearance.BorderColor = Color.LightGray;
            btnAcreditar.FlatStyle = FlatStyle.Flat;
            btnAcreditar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAcreditar.Location = new Point(584, 470);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(150, 30);
            btnAcreditar.TabIndex = 59;
            btnAcreditar.Text = "Acreditar Paciente";
            btnAcreditar.UseVisualStyleBackColor = true;
            btnAcreditar.Click += btnAcreditar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblCoberturaPaciente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panel3);
            groupBox1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(206, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 100);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cobro del estudio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(206, 292);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 62;
            label2.Text = "Seleccione lugar de atención";
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(206, 310);
            cbxLugar.Name = "cbxLugar";
            cbxLugar.Size = new Size(234, 23);
            cbxLugar.TabIndex = 61;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(39, 22);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(64, 19);
            rbtNormal.TabIndex = 55;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtUrgencia
            // 
            rbtUrgencia.AutoSize = true;
            rbtUrgencia.Location = new Point(142, 23);
            rbtUrgencia.Name = "rbtUrgencia";
            rbtUrgencia.Size = new Size(72, 19);
            rbtUrgencia.TabIndex = 54;
            rbtUrgencia.Text = "Urgencia";
            rbtUrgencia.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(rbtNormal);
            groupBox2.Controls.Add(rbtUrgencia);
            groupBox2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(482, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 55);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prioridad";
            // 
            // btnNuevaAcreditacion
            // 
            btnNuevaAcreditacion.FlatAppearance.BorderColor = Color.LightGray;
            btnNuevaAcreditacion.FlatStyle = FlatStyle.Flat;
            btnNuevaAcreditacion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnNuevaAcreditacion.Location = new Point(584, 506);
            btnNuevaAcreditacion.Name = "btnNuevaAcreditacion";
            btnNuevaAcreditacion.Size = new Size(150, 30);
            btnNuevaAcreditacion.TabIndex = 64;
            btnNuevaAcreditacion.Text = "Nueva Acreditacion";
            btnNuevaAcreditacion.UseVisualStyleBackColor = true;
            btnNuevaAcreditacion.Click += NuevaAcreditacion_Click;
            // 
            // pnlAcreditacion
            // 
            pnlAcreditacion.BackgroundImage = (Image)resources.GetObject("pnlAcreditacion.BackgroundImage");
            pnlAcreditacion.BackgroundImageLayout = ImageLayout.Center;
            pnlAcreditacion.BorderStyle = BorderStyle.FixedSingle;
            pnlAcreditacion.Controls.Add(btnImprimirComprobante);
            pnlAcreditacion.Controls.Add(btnNuevaAcreditacion);
            pnlAcreditacion.Controls.Add(groupBox2);
            pnlAcreditacion.Controls.Add(label2);
            pnlAcreditacion.Controls.Add(cbxLugar);
            pnlAcreditacion.Controls.Add(groupBox1);
            pnlAcreditacion.Controls.Add(btnAcreditar);
            pnlAcreditacion.Controls.Add(lblTituloA);
            pnlAcreditacion.Controls.Add(label1);
            pnlAcreditacion.Controls.Add(lbxTurnos);
            pnlAcreditacion.Controls.Add(lblEstudio);
            pnlAcreditacion.Controls.Add(cbxEstudios);
            pnlAcreditacion.Controls.Add(btnRegistrarPaciente);
            pnlAcreditacion.Controls.Add(label3);
            pnlAcreditacion.Controls.Add(cbxPaciente);
            pnlAcreditacion.Controls.Add(btnVolver);
            pnlAcreditacion.Controls.Add(panel2);
            pnlAcreditacion.Controls.Add(btnSalir);
            pnlAcreditacion.Location = new Point(12, 12);
            pnlAcreditacion.Name = "pnlAcreditacion";
            pnlAcreditacion.Size = new Size(836, 644);
            pnlAcreditacion.TabIndex = 65;
            // 
            // btnImprimirComprobante
            // 
            btnImprimirComprobante.FlatAppearance.BorderColor = Color.LightGray;
            btnImprimirComprobante.FlatStyle = FlatStyle.Flat;
            btnImprimirComprobante.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnImprimirComprobante.Location = new Point(479, 542);
            btnImprimirComprobante.Name = "btnImprimirComprobante";
            btnImprimirComprobante.Size = new Size(184, 30);
            btnImprimirComprobante.TabIndex = 65;
            btnImprimirComprobante.Text = "Imprimir Comprobante";
            btnImprimirComprobante.UseVisualStyleBackColor = true;
            btnImprimirComprobante.Click += btnImprimirComprobante_Click;
            // 
            // frmAcreditacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 663);
            Controls.Add(pnlAcreditacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(55, 54);
            Name = "frmAcreditacion";
            Text = "Acreditación";
            Load += frmAcreditacion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlAcreditacion.ResumeLayout(false);
            pnlAcreditacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Panel panel2;
        private Button btnSalir;
        private Button btnRegistrarPaciente;
        private Label label3;
        private ComboBox cbxPaciente;
        private Label lblEstudio;
        private ComboBox cbxEstudios;
        private ListBox lbxTurnos;
        private Label label1;
        private Label label4;
        private Label lblCoberturaPaciente;
        private Label lblTituloA;
        private Label lblMonto;
        private Label label7;
        private Label lblMedioPago;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private Panel panel1;
        private Panel panel3;
        private Label lblRegistroPago;
        private RadioButton rbtPagado;
        private RadioButton rbtAdeudado;
        private Button btnAcreditar;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cbxLugar;
        private RadioButton rbtNormal;
        private RadioButton rbtUrgencia;
        private GroupBox groupBox2;
        private Button btnNuevaAcreditacion;
        private Panel pnlAcreditacion;
        private Button btnImprimirComprobante;
    }
}