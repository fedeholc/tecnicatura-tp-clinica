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
            label6 = new Label();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(469, 459);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(16, 446);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 1);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(388, 459);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(391, 40);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(153, 23);
            btnRegistrarPaciente.TabIndex = 42;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 44);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 41;
            label3.Text = "Seleccione Paciente";
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(137, 40);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(234, 23);
            cbxPaciente.TabIndex = 40;
            cbxPaciente.SelectedIndexChanged += cbxPaciente_SelectedIndexChanged;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.Location = new Point(16, 79);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(95, 15);
            lblEstudio.TabIndex = 44;
            lblEstudio.Text = "Estudio a realizar";
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(137, 76);
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
            lbxTurnos.Location = new Point(16, 132);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(527, 72);
            lbxTurnos.TabIndex = 45;
            lbxTurnos.SelectedIndexChanged += lbxTurnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 114);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 46;
            label1.Text = "Turnos del paciente seleccionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 31);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(16, 9);
            label6.Name = "label6";
            label6.Size = new Size(207, 21);
            label6.TabIndex = 50;
            label6.Text = "Acreditación de Pacientes";
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
            label7.Location = new Point(278, 31);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 51;
            label7.Text = "Monto a pagar:";
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Location = new Point(3, 5);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(90, 15);
            lblMedioPago.TabIndex = 53;
            lblMedioPago.Text = "Medio de pago:";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(100, 3);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
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
            rbtTarjeta.Size = new Size(59, 19);
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
            lblRegistroPago.Size = new Size(90, 15);
            lblRegistroPago.TabIndex = 53;
            lblRegistroPago.Text = "Registrar cómo:";
            // 
            // rbtPagado
            // 
            rbtPagado.AutoSize = true;
            rbtPagado.Location = new Point(98, 5);
            rbtPagado.Name = "rbtPagado";
            rbtPagado.Size = new Size(65, 19);
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
            btnAcreditar.Font = new Font("Segoe UI", 9.75F);
            btnAcreditar.Location = new Point(404, 398);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(140, 32);
            btnAcreditar.TabIndex = 59;
            btnAcreditar.Text = "Acreditar Paciente";
            btnAcreditar.UseVisualStyleBackColor = true;
            btnAcreditar.Click += btnAcreditar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCoberturaPaciente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panel3);
            groupBox1.Location = new Point(16, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 100);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cobro del estudio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 221);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 62;
            label2.Text = "Seleccione lugar de atención";
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(16, 239);
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
            rbtNormal.Size = new Size(65, 19);
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
            groupBox2.Controls.Add(rbtNormal);
            groupBox2.Controls.Add(rbtUrgencia);
            groupBox2.Location = new Point(292, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 55);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prioridad";
            // 
            // btnNuevaAcreditacion
            // 
            btnNuevaAcreditacion.Location = new Point(16, 459);
            btnNuevaAcreditacion.Name = "btnNuevaAcreditacion";
            btnNuevaAcreditacion.Size = new Size(132, 23);
            btnNuevaAcreditacion.TabIndex = 64;
            btnNuevaAcreditacion.Text = "Nueva Acreditacion";
            btnNuevaAcreditacion.UseVisualStyleBackColor = true;
            btnNuevaAcreditacion.Click += NuevaAcreditacion_Click;
            // 
            // frmAcreditacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 503);
            Controls.Add(btnNuevaAcreditacion);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(cbxLugar);
            Controls.Add(groupBox1);
            Controls.Add(btnAcreditar);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(lbxTurnos);
            Controls.Add(lblEstudio);
            Controls.Add(cbxEstudios);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(label3);
            Controls.Add(cbxPaciente);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            MinimumSize = new Size(60, 0);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Label label6;
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
    }
}