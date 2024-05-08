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
            label2 = new Label();
            label4 = new Label();
            lblCoberturaPaciente = new Label();
            label6 = new Label();
            lblMonto = new Label();
            label7 = new Label();
            label5 = new Label();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            panel1 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            rbtPagado = new RadioButton();
            rbtAdeudado = new RadioButton();
            panel4 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(469, 406);
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
            panel2.Location = new Point(16, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 1);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(388, 406);
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 44);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 41;
            label3.Text = "Seleccionar Paciente";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 221);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 47;
            label2.Text = "Cobro del estudio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 15);
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
            lblCoberturaPaciente.Location = new Point(114, 12);
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
            lblMonto.Location = new Point(367, 12);
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
            label7.Location = new Point(278, 15);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 51;
            label7.Text = "Monto a pagar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 5);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 53;
            label5.Text = "Medio de pago:";
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rbtTarjeta);
            panel1.Controls.Add(rbtEfectivo);
            panel1.Location = new Point(5, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 25);
            panel1.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(rbtPagado);
            panel3.Controls.Add(rbtAdeudado);
            panel3.Location = new Point(276, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 29);
            panel3.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 7);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 53;
            label8.Text = "Registrar cómo:";
            label8.Click += label8_Click;
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblCoberturaPaciente);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblMonto);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(16, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(527, 83);
            panel4.TabIndex = 58;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(404, 342);
            button1.Name = "button1";
            button1.Size = new Size(140, 32);
            button1.TabIndex = 59;
            button1.Text = "Acreditar Paciente";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAcreditacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(label6);
            Controls.Add(label2);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label2;
        private Label label4;
        private Label lblCoberturaPaciente;
        private Label label6;
        private Label lblMonto;
        private Label label7;
        private Label label5;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private Panel panel1;
        private Panel panel3;
        private Label label8;
        private RadioButton rbtPagado;
        private RadioButton rbtAdeudado;
        private Panel panel4;
        private Button button1;
    }
}