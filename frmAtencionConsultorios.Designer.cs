namespace clinica
{
    partial class frmAtencionConsultorios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnVolver = new Button();
            btnSalir = new Button();
            cbxLugar = new ComboBox();
            label1 = new Label();
            lbxEnEspera = new ListBox();
            label2 = new Label();
            rtxtHistoriaClinica = new RichTextBox();
            label3 = new Label();
            btnRegistrarAtencion = new Button();
            btnPacienteAusente = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(149, 539);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(14, 539);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(147, 29);
            cbxLugar.Margin = new Padding(3, 4, 3, 4);
            cbxLugar.Name = "cbxLugar";
            cbxLugar.Size = new Size(394, 28);
            cbxLugar.TabIndex = 2;
            cbxLugar.SelectedIndexChanged += cbxLugar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 33);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 3;
            label1.Text = "Seleccione un profesional :";
            // 
            // lbxEnEspera
            // 
            lbxEnEspera.FormattingEnabled = true;
            lbxEnEspera.Location = new Point(14, 112);
            lbxEnEspera.Margin = new Padding(3, 4, 3, 4);
            lbxEnEspera.Name = "lbxEnEspera";
            lbxEnEspera.Size = new Size(527, 144);
            lbxEnEspera.TabIndex = 4;
            lbxEnEspera.SelectedIndexChanged += lbxEnEspera_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "En Espera :";
            // 
            // rtxtHistoriaClinica
            // 
            rtxtHistoriaClinica.Location = new Point(14, 301);
            rtxtHistoriaClinica.Margin = new Padding(3, 4, 3, 4);
            rtxtHistoriaClinica.Name = "rtxtHistoriaClinica";
            rtxtHistoriaClinica.Size = new Size(527, 212);
            rtxtHistoriaClinica.TabIndex = 6;
            rtxtHistoriaClinica.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 277);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 7;
            label3.Text = "Historia Clínica :";
            // 
            // btnRegistrarAtencion
            // 
            btnRegistrarAtencion.Location = new Point(328, 539);
            btnRegistrarAtencion.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarAtencion.Name = "btnRegistrarAtencion";
            btnRegistrarAtencion.Size = new Size(214, 31);
            btnRegistrarAtencion.TabIndex = 8;
            btnRegistrarAtencion.Text = "Registrar Atención Paciente";
            btnRegistrarAtencion.UseVisualStyleBackColor = true;
            btnRegistrarAtencion.Click += btnRegistrarAtencion_Click;
            // 
            // btnPacienteAusente
            // 
            btnPacienteAusente.Location = new Point(328, 577);
            btnPacienteAusente.Margin = new Padding(3, 4, 3, 4);
            btnPacienteAusente.Name = "btnPacienteAusente";
            btnPacienteAusente.Size = new Size(214, 31);
            btnPacienteAusente.TabIndex = 9;
            btnPacienteAusente.Text = "Registrar Paciente Ausente";
            btnPacienteAusente.UseVisualStyleBackColor = true;
            btnPacienteAusente.Click += btnPacienteAusente_Click;
            // 
            // frmAtencionConsultorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 621);
            Controls.Add(btnPacienteAusente);
            Controls.Add(btnRegistrarAtencion);
            Controls.Add(label3);
            Controls.Add(rtxtHistoriaClinica);
            Controls.Add(label2);
            Controls.Add(lbxEnEspera);
            Controls.Add(label1);
            Controls.Add(cbxLugar);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAtencionConsultorios";
            Text = "Atención en Consultorios";
            Load += frmAtencionConsultorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxEnEspera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtHistoriaClinica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarAtencion;
        private System.Windows.Forms.Button btnPacienteAusente;
    }
}
