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
            btnVolver = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            label2 = new Label();
            cbxLugar = new ComboBox();
            lbxEnEspera = new ListBox();
            rtxtHistoriaClinica = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            btnAcreditar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(588, 328);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 45;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(17, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 1);
            panel2.TabIndex = 44;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(507, 328);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 43;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 64;
            label2.Text = "Seleccione lugar de atención";
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(17, 39);
            cbxLugar.Name = "cbxLugar";
            cbxLugar.Size = new Size(234, 23);
            cbxLugar.TabIndex = 63;
            cbxLugar.SelectedIndexChanged += cbxLugar_SelectedIndexChanged;
            // 
            // lbxEnEspera
            // 
            lbxEnEspera.FormattingEnabled = true;
            lbxEnEspera.ItemHeight = 15;
            lbxEnEspera.Location = new Point(17, 96);
            lbxEnEspera.Name = "lbxEnEspera";
            lbxEnEspera.Size = new Size(234, 154);
            lbxEnEspera.TabIndex = 65;
            lbxEnEspera.SelectedIndexChanged += lbxEnEspera_SelectedIndexChanged;
            // 
            // rtxtHistoriaClinica
            // 
            rtxtHistoriaClinica.Location = new Point(281, 96);
            rtxtHistoriaClinica.Name = "rtxtHistoriaClinica";
            rtxtHistoriaClinica.Size = new Size(382, 154);
            rtxtHistoriaClinica.TabIndex = 67;
            rtxtHistoriaClinica.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 78);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 68;
            label1.Text = "Seleccione Paciente de lista de espera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 78);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 69;
            label3.Text = "Historia Clínica del paciente";
            // 
            // btnAcreditar
            // 
            btnAcreditar.Font = new Font("Segoe UI", 9.75F);
            btnAcreditar.Location = new Point(477, 267);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(186, 32);
            btnAcreditar.TabIndex = 70;
            btnAcreditar.Text = "Registrar Paciente Atendido";
            btnAcreditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(65, 267);
            button1.Name = "button1";
            button1.Size = new Size(186, 32);
            button1.TabIndex = 71;
            button1.Text = "Registrar Paciente Ausente";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 367);
            Controls.Add(button1);
            Controls.Add(btnAcreditar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(rtxtHistoriaClinica);
            Controls.Add(lbxEnEspera);
            Controls.Add(label2);
            Controls.Add(cbxLugar);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            Name = "frmAtencion";
            Text = "frmAtencion";
            Load += frmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnAcreditar;
        private Button button1;
    }
}