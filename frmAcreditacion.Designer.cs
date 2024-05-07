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
            // frmAcreditacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 483);
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
    }
}