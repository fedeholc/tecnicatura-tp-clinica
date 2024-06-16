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
            cbxProfesionalSE = new ComboBox();
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
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.Location = new Point(946, 842);
            btnVolver.Margin = new Padding(5, 6, 5, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(247, 59);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.Location = new Point(946, 914);
            btnSalir.Margin = new Padding(5, 6, 5, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(247, 59);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbxProfesionalSE
            // 
            cbxProfesionalSE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProfesionalSE.FormattingEnabled = true;
            cbxProfesionalSE.Location = new Point(335, 53);
            cbxProfesionalSE.Margin = new Padding(5, 6, 5, 6);
            cbxProfesionalSE.Name = "cbxProfesionalSE";
            cbxProfesionalSE.Size = new Size(856, 40);
            cbxProfesionalSE.TabIndex = 2;
            cbxProfesionalSE.SelectedIndexChanged += cbxProfesionalSE_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 3;
            label1.Text = "Seleccione un profesional :";
            // 
            // lbxEnEspera
            // 
            lbxEnEspera.FormattingEnabled = true;
            lbxEnEspera.Location = new Point(23, 179);
            lbxEnEspera.Margin = new Padding(5, 6, 5, 6);
            lbxEnEspera.Name = "lbxEnEspera";
            lbxEnEspera.Size = new Size(1168, 228);
            lbxEnEspera.TabIndex = 4;
            lbxEnEspera.SelectedIndexChanged += lbxEnEspera_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 141);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 5;
            label2.Text = "En Espera :";
            // 
            // rtxtHistoriaClinica
            // 
            rtxtHistoriaClinica.Location = new Point(23, 482);
            rtxtHistoriaClinica.Margin = new Padding(5, 6, 5, 6);
            rtxtHistoriaClinica.Name = "rtxtHistoriaClinica";
            rtxtHistoriaClinica.Size = new Size(1168, 337);
            rtxtHistoriaClinica.TabIndex = 6;
            rtxtHistoriaClinica.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 443);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 32);
            label3.TabIndex = 7;
            label3.Text = "Historia Clínica :";
            // 
            // btnRegistrarAtencion
            // 
            btnRegistrarAtencion.BackColor = SystemColors.ActiveCaption;
            btnRegistrarAtencion.Location = new Point(23, 877);
            btnRegistrarAtencion.Margin = new Padding(5, 6, 5, 6);
            btnRegistrarAtencion.Name = "btnRegistrarAtencion";
            btnRegistrarAtencion.Size = new Size(358, 59);
            btnRegistrarAtencion.TabIndex = 8;
            btnRegistrarAtencion.Text = "Registrar Atención Paciente";
            btnRegistrarAtencion.UseVisualStyleBackColor = false;
            btnRegistrarAtencion.Click += btnRegistrarAtencion_Click;
            // 
            // btnPacienteAusente
            // 
            btnPacienteAusente.BackColor = SystemColors.ActiveCaption;
            btnPacienteAusente.Location = new Point(489, 877);
            btnPacienteAusente.Margin = new Padding(5, 6, 5, 6);
            btnPacienteAusente.Name = "btnPacienteAusente";
            btnPacienteAusente.Size = new Size(358, 59);
            btnPacienteAusente.TabIndex = 9;
            btnPacienteAusente.Text = "Registrar Paciente Ausente";
            btnPacienteAusente.UseVisualStyleBackColor = false;
            btnPacienteAusente.Click += btnPacienteAusente_Click;
            // 
            // frmAtencionConsultorios
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 994);
            Controls.Add(btnPacienteAusente);
            Controls.Add(btnRegistrarAtencion);
            Controls.Add(label3);
            Controls.Add(rtxtHistoriaClinica);
            Controls.Add(label2);
            Controls.Add(lbxEnEspera);
            Controls.Add(label1);
            Controls.Add(cbxProfesionalSE);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmAtencionConsultorios";
            Text = "Atención en Consultorios";
            Load += frmAtencionConsultorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxProfesionalSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxEnEspera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtHistoriaClinica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarAtencion;
        private System.Windows.Forms.Button btnPacienteAusente;
    }
}