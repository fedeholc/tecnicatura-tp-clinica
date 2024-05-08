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
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(783, 448);
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
            panel2.Location = new Point(16, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 1);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(702, 448);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(282, 61);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(153, 23);
            btnRegistrarPaciente.TabIndex = 42;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(190, 15);
            label3.TabIndex = 41;
            label3.Text = "Seleccionar Paciente para acreditar";
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(16, 61);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(251, 23);
            cbxPaciente.TabIndex = 40;
            cbxPaciente.SelectedIndexChanged += cbxPaciente_SelectedIndexChanged;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.Location = new Point(16, 104);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(95, 15);
            lblEstudio.TabIndex = 44;
            lblEstudio.Text = "Estudio a realizar";
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(16, 122);
            cbxEstudios.Name = "cbxEstudios";
            cbxEstudios.Size = new Size(250, 23);
            cbxEstudios.TabIndex = 43;
            // 
            // lbxTurnos
            // 
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 15;
            lbxTurnos.Location = new Point(16, 205);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(419, 79);
            lbxTurnos.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 187);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 46;
            label1.Text = "Turnos del paciente seleccionado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(495, 42);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 47;
            label2.Text = "Cobro del estudio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 65);
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
            lblCoberturaPaciente.Location = new Point(613, 62);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(613, 101);
            label5.MaximumSize = new Size(150, 0);
            label5.MinimumSize = new Size(50, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(2);
            label5.Size = new Size(50, 21);
            label5.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 104);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 51;
            label7.Text = "Monto a pagar:";
            // 
            // frmAcreditacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 483);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblCoberturaPaciente);
            Controls.Add(label4);
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
        private Label label5;
        private Label label7;
    }
}