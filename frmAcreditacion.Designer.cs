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
            btnVolver.Location = new Point(1242, 1156);
            btnVolver.Margin = new Padding(6, 6, 6, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(121, 60);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(383, 171);
            panel2.Margin = new Padding(6, 6, 6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 0);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1252, 98);
            btnSalir.Margin = new Padding(6, 6, 6, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 60);
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
            btnRegistrarPaciente.Location = new Point(1085, 237);
            btnRegistrarPaciente.Margin = new Padding(6, 6, 6, 6);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(279, 64);
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
            label3.Location = new Point(383, 245);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 41;
            label3.Text = "Seleccione Paciente";
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(607, 237);
            cbxPaciente.Margin = new Padding(6, 6, 6, 6);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(431, 40);
            cbxPaciente.TabIndex = 40;
            cbxPaciente.SelectedIndexChanged += cbxPaciente_SelectedIndexChanged;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.BackColor = Color.Transparent;
            lblEstudio.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEstudio.Location = new Point(383, 320);
            lblEstudio.Margin = new Padding(6, 0, 6, 0);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(193, 32);
            lblEstudio.TabIndex = 44;
            lblEstudio.Text = "Estudio a realizar";
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(607, 314);
            cbxEstudios.Margin = new Padding(6, 6, 6, 6);
            cbxEstudios.Name = "cbxEstudios";
            cbxEstudios.Size = new Size(429, 40);
            cbxEstudios.TabIndex = 43;
            cbxEstudios.SelectedIndexChanged += cbxEstudios_SelectedIndexChanged;
            // 
            // lbxTurnos
            // 
            lbxTurnos.Font = new Font("Segoe UI", 9.75F);
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 36;
            lbxTurnos.Location = new Point(383, 433);
            lbxTurnos.Margin = new Padding(6, 6, 6, 6);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(975, 148);
            lbxTurnos.TabIndex = 45;
            lbxTurnos.SelectedIndexChanged += lbxTurnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(383, 395);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 32);
            label1.TabIndex = 46;
            label1.Text = "Turnos del paciente seleccionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label4.Location = new Point(11, 66);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 48;
            label4.Text = "Cobertura médica:";
            // 
            // lblCoberturaPaciente
            // 
            lblCoberturaPaciente.AutoSize = true;
            lblCoberturaPaciente.BackColor = SystemColors.ControlLightLight;
            lblCoberturaPaciente.BorderStyle = BorderStyle.FixedSingle;
            lblCoberturaPaciente.Location = new Point(212, 60);
            lblCoberturaPaciente.Margin = new Padding(6, 0, 6, 0);
            lblCoberturaPaciente.MaximumSize = new Size(277, 2);
            lblCoberturaPaciente.MinimumSize = new Size(277, 2);
            lblCoberturaPaciente.Name = "lblCoberturaPaciente";
            lblCoberturaPaciente.Padding = new Padding(4, 4, 4, 4);
            lblCoberturaPaciente.Size = new Size(277, 2);
            lblCoberturaPaciente.TabIndex = 49;
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(383, 119);
            lblTituloA.Margin = new Padding(6, 0, 6, 0);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(425, 46);
            lblTituloA.TabIndex = 50;
            lblTituloA.Text = "Acreditación de Pacientes";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = SystemColors.ControlLightLight;
            lblMonto.BorderStyle = BorderStyle.FixedSingle;
            lblMonto.Location = new Point(682, 60);
            lblMonto.Margin = new Padding(6, 0, 6, 0);
            lblMonto.MaximumSize = new Size(277, 2);
            lblMonto.MinimumSize = new Size(91, 2);
            lblMonto.Name = "lblMonto";
            lblMonto.Padding = new Padding(4, 4, 4, 4);
            lblMonto.Size = new Size(91, 2);
            lblMonto.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label7.Location = new Point(516, 66);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(177, 32);
            label7.TabIndex = 51;
            label7.Text = "Monto a pagar:";
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Location = new Point(6, 11);
            lblMedioPago.Margin = new Padding(6, 0, 6, 0);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(176, 32);
            lblMedioPago.TabIndex = 53;
            lblMedioPago.Text = "Medio de pago:";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(186, 6);
            rbtEfectivo.Margin = new Padding(6, 6, 6, 6);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(126, 36);
            rbtEfectivo.TabIndex = 54;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(321, 6);
            rbtTarjeta.Margin = new Padding(6, 6, 6, 6);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(118, 36);
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
            panel1.Location = new Point(9, 130);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 53);
            panel1.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblRegistroPago);
            panel3.Controls.Add(rbtPagado);
            panel3.Controls.Add(rbtAdeudado);
            panel3.Location = new Point(513, 126);
            panel3.Margin = new Padding(6, 6, 6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 62);
            panel3.TabIndex = 57;
            // 
            // lblRegistroPago
            // 
            lblRegistroPago.AutoSize = true;
            lblRegistroPago.Location = new Point(6, 15);
            lblRegistroPago.Margin = new Padding(6, 0, 6, 0);
            lblRegistroPago.Name = "lblRegistroPago";
            lblRegistroPago.Size = new Size(178, 32);
            lblRegistroPago.TabIndex = 53;
            lblRegistroPago.Text = "Registrar cómo:";
            // 
            // rbtPagado
            // 
            rbtPagado.AutoSize = true;
            rbtPagado.Location = new Point(182, 11);
            rbtPagado.Margin = new Padding(6, 6, 6, 6);
            rbtPagado.Name = "rbtPagado";
            rbtPagado.Size = new Size(122, 36);
            rbtPagado.TabIndex = 55;
            rbtPagado.TabStop = true;
            rbtPagado.Text = "Pagado";
            rbtPagado.UseVisualStyleBackColor = true;
            // 
            // rbtAdeudado
            // 
            rbtAdeudado.AutoSize = true;
            rbtAdeudado.Location = new Point(305, 11);
            rbtAdeudado.Margin = new Padding(6, 6, 6, 6);
            rbtAdeudado.Name = "rbtAdeudado";
            rbtAdeudado.Size = new Size(150, 36);
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
            btnAcreditar.Location = new Point(1085, 1003);
            btnAcreditar.Margin = new Padding(6, 6, 6, 6);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(279, 64);
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
            groupBox1.Location = new Point(383, 751);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(981, 213);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cobro del estudio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(383, 623);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 32);
            label2.TabIndex = 62;
            label2.Text = "Seleccione lugar de atención";
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(383, 661);
            cbxLugar.Margin = new Padding(6, 6, 6, 6);
            cbxLugar.Name = "cbxLugar";
            cbxLugar.Size = new Size(431, 40);
            cbxLugar.TabIndex = 61;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(72, 47);
            rbtNormal.Margin = new Padding(6, 6, 6, 6);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(123, 36);
            rbtNormal.TabIndex = 55;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtUrgencia
            // 
            rbtUrgencia.AutoSize = true;
            rbtUrgencia.Location = new Point(264, 49);
            rbtUrgencia.Margin = new Padding(6, 6, 6, 6);
            rbtUrgencia.Name = "rbtUrgencia";
            rbtUrgencia.Size = new Size(139, 36);
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
            groupBox2.Location = new Point(895, 621);
            groupBox2.Margin = new Padding(6, 6, 6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 6, 6, 6);
            groupBox2.Size = new Size(468, 117);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prioridad";
            // 
            // btnNuevaAcreditacion
            // 
            btnNuevaAcreditacion.FlatAppearance.BorderColor = Color.LightGray;
            btnNuevaAcreditacion.FlatStyle = FlatStyle.Flat;
            btnNuevaAcreditacion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnNuevaAcreditacion.Location = new Point(1085, 1079);
            btnNuevaAcreditacion.Margin = new Padding(6, 6, 6, 6);
            btnNuevaAcreditacion.Name = "btnNuevaAcreditacion";
            btnNuevaAcreditacion.Size = new Size(279, 64);
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
            pnlAcreditacion.Location = new Point(22, 26);
            pnlAcreditacion.Margin = new Padding(6, 6, 6, 6);
            pnlAcreditacion.Name = "pnlAcreditacion";
            pnlAcreditacion.Size = new Size(1551, 1372);
            pnlAcreditacion.TabIndex = 65;
            pnlAcreditacion.Paint += pnlAcreditacion_Paint;
            // 
            // frmAcreditacion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 1399);
            Controls.Add(pnlAcreditacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(89, 71);
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
    }
}