
namespace clinica
{
    partial class frmAcreditacionConsultorios
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
            cbxProfesionales = new ComboBox();
            lbxTurnos = new ListBox();
            label1 = new Label();
            lblTituloA = new Label();
            btnAcreditar = new Button();
            rbtNormal = new RadioButton();
            rbtUrgencia = new RadioButton();
            groupBox2 = new GroupBox();
            btnNuevaAcreditacion = new Button();
            pnlAcreditacion = new Panel();
            groupBox2.SuspendLayout();
            pnlAcreditacion.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1069, 811);
            btnVolver.Margin = new Padding(5, 6, 5, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(294, 59);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(382, 171);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 0);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1116, 99);
            btnSalir.Margin = new Padding(5, 6, 5, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(247, 59);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.BackColor = SystemColors.ActiveCaption;
            btnRegistrarPaciente.FlatAppearance.BorderColor = Color.LightGray;
            btnRegistrarPaciente.FlatStyle = FlatStyle.Flat;
            btnRegistrarPaciente.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarPaciente.Location = new Point(1116, 237);
            btnRegistrarPaciente.Margin = new Padding(5, 6, 5, 6);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(247, 117);
            btnRegistrarPaciente.TabIndex = 42;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = false;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label3.Location = new Point(382, 245);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 41;
            label3.Text = "Seleccione Paciente";
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(608, 237);
            cbxPaciente.Margin = new Padding(5, 6, 5, 6);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(431, 40);
            cbxPaciente.TabIndex = 40;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.BackColor = Color.Transparent;
            lblEstudio.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEstudio.Location = new Point(382, 320);
            lblEstudio.Margin = new Padding(5, 0, 5, 0);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(244, 32);
            lblEstudio.TabIndex = 44;
            lblEstudio.Text = "Seleccione Profesional";
            // 
            // cbxProfesionales
            // 
            cbxProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProfesionales.FormattingEnabled = true;
            cbxProfesionales.Location = new Point(608, 314);
            cbxProfesionales.Margin = new Padding(5, 6, 5, 6);
            cbxProfesionales.Name = "cbxProfesionales";
            cbxProfesionales.Size = new Size(430, 40);
            cbxProfesionales.TabIndex = 43;
            cbxProfesionales.SelectedIndexChanged += cbxProfesionales_SelectedIndexChanged;
            // 
            // lbxTurnos
            // 
            lbxTurnos.Font = new Font("Segoe UI", 9.75F);
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 36;
            lbxTurnos.Location = new Point(382, 434);
            lbxTurnos.Margin = new Padding(5, 6, 5, 6);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(976, 112);
            lbxTurnos.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(382, 395);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 32);
            label1.TabIndex = 46;
            label1.Text = "Turnos del paciente seleccionado";
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(382, 120);
            lblTituloA.Margin = new Padding(5, 0, 5, 0);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(425, 46);
            lblTituloA.TabIndex = 50;
            lblTituloA.Text = "Acreditación de Pacientes";
            // 
            // btnAcreditar
            // 
            btnAcreditar.BackColor = SystemColors.ActiveCaption;
            btnAcreditar.FlatAppearance.BorderColor = Color.LightGray;
            btnAcreditar.FlatStyle = FlatStyle.Flat;
            btnAcreditar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAcreditar.Location = new Point(382, 811);
            btnAcreditar.Margin = new Padding(5, 6, 5, 6);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(294, 59);
            btnAcreditar.TabIndex = 59;
            btnAcreditar.Text = "Acreditar Paciente";
            btnAcreditar.UseVisualStyleBackColor = false;
            btnAcreditar.Click += btnAcreditar_Click;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(73, 46);
            rbtNormal.Margin = new Padding(5, 6, 5, 6);
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
            rbtUrgencia.Location = new Point(263, 50);
            rbtUrgencia.Margin = new Padding(5, 6, 5, 6);
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
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(468, 117);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prioridad";
            // 
            // btnNuevaAcreditacion
            // 
            btnNuevaAcreditacion.BackColor = SystemColors.ActiveCaption;
            btnNuevaAcreditacion.FlatAppearance.BorderColor = Color.LightGray;
            btnNuevaAcreditacion.FlatStyle = FlatStyle.Flat;
            btnNuevaAcreditacion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnNuevaAcreditacion.Location = new Point(728, 811);
            btnNuevaAcreditacion.Margin = new Padding(5, 6, 5, 6);
            btnNuevaAcreditacion.Name = "btnNuevaAcreditacion";
            btnNuevaAcreditacion.Size = new Size(294, 59);
            btnNuevaAcreditacion.TabIndex = 64;
            btnNuevaAcreditacion.Text = "Nueva Acreditacion";
            btnNuevaAcreditacion.UseVisualStyleBackColor = false;
            btnNuevaAcreditacion.Click += NuevaAcreditacion_Click;
            // 
            // pnlAcreditacion
            // 
            pnlAcreditacion.BackgroundImageLayout = ImageLayout.Center;
            pnlAcreditacion.BorderStyle = BorderStyle.FixedSingle;
            pnlAcreditacion.Controls.Add(btnNuevaAcreditacion);
            pnlAcreditacion.Controls.Add(groupBox2);
            pnlAcreditacion.Controls.Add(btnAcreditar);
            pnlAcreditacion.Controls.Add(lblTituloA);
            pnlAcreditacion.Controls.Add(label1);
            pnlAcreditacion.Controls.Add(lbxTurnos);
            pnlAcreditacion.Controls.Add(lblEstudio);
            pnlAcreditacion.Controls.Add(cbxProfesionales);
            pnlAcreditacion.Controls.Add(btnRegistrarPaciente);
            pnlAcreditacion.Controls.Add(label3);
            pnlAcreditacion.Controls.Add(cbxPaciente);
            pnlAcreditacion.Controls.Add(btnVolver);
            pnlAcreditacion.Controls.Add(panel2);
            pnlAcreditacion.Controls.Add(btnSalir);
            pnlAcreditacion.Location = new Point(23, 26);
            pnlAcreditacion.Margin = new Padding(5, 6, 5, 6);
            pnlAcreditacion.Name = "pnlAcreditacion";
            pnlAcreditacion.Size = new Size(1846, 1372);
            pnlAcreditacion.TabIndex = 65;
            // 
            // frmAcreditacionConsultorios
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1890, 938);
            Controls.Add(pnlAcreditacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(91, 71);
            Name = "frmAcreditacionConsultorios";
            Text = "Acreditación Consultorios";
            Load += frmAcreditacionConsultorios_Load_1;
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
        private ComboBox cbxProfesionales;
        private ListBox lbxTurnos;
        private Label label1;
        private Label lblTituloA;
        private Button btnAcreditar;
        private RadioButton rbtNormal;
        private RadioButton rbtUrgencia;
        private GroupBox groupBox2;
        private Button btnNuevaAcreditacion;
        private Panel pnlAcreditacion;
    }
}