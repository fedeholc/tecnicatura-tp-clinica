
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
            label2 = new Label();
            cbxLugar = new ComboBox();
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
            btnVolver.Location = new Point(658, 507);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 37);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(235, 107);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 1);
            panel2.TabIndex = 38;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(687, 62);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 37);
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
            btnRegistrarPaciente.Location = new Point(687, 148);
            btnRegistrarPaciente.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(152, 73);
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
            label3.Location = new Point(235, 153);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 41;
            label3.Text = "Seleccione Paciente";
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(374, 148);
            cbxPaciente.Margin = new Padding(3, 4, 3, 4);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(267, 28);
            cbxPaciente.TabIndex = 40;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.BackColor = Color.Transparent;
            lblEstudio.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEstudio.Location = new Point(235, 200);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(165, 21);
            lblEstudio.TabIndex = 44;
            lblEstudio.Text = "Seleccione Profesional";
            // 
            // cbxProfesionales
            // 
            cbxProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProfesionales.FormattingEnabled = true;
            cbxProfesionales.Location = new Point(374, 196);
            cbxProfesionales.Margin = new Padding(3, 4, 3, 4);
            cbxProfesionales.Name = "cbxProfesionales";
            cbxProfesionales.Size = new Size(266, 28);
            cbxProfesionales.TabIndex = 43;
            // 
            // lbxTurnos
            // 
            lbxTurnos.Font = new Font("Segoe UI", 9.75F);
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 21;
            lbxTurnos.Location = new Point(235, 271);
            lbxTurnos.Margin = new Padding(3, 4, 3, 4);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(602, 88);
            lbxTurnos.TabIndex = 45;
            lbxTurnos.SelectedIndexChanged += lbxTurnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(235, 247);
            label1.Name = "label1";
            label1.Size = new Size(240, 21);
            label1.TabIndex = 46;
            label1.Text = "Turnos del paciente seleccionado";
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(235, 75);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(271, 29);
            lblTituloA.TabIndex = 50;
            lblTituloA.Text = "Acreditación de Pacientes";
            // 
            // btnAcreditar
            // 
            btnAcreditar.BackColor = SystemColors.ActiveCaption;
            btnAcreditar.FlatAppearance.BorderColor = Color.LightGray;
            btnAcreditar.FlatStyle = FlatStyle.Flat;
            btnAcreditar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAcreditar.Location = new Point(235, 507);
            btnAcreditar.Margin = new Padding(3, 4, 3, 4);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(181, 37);
            btnAcreditar.TabIndex = 59;
            btnAcreditar.Text = "Acreditar Paciente";
            btnAcreditar.UseVisualStyleBackColor = false;
            btnAcreditar.Click += btnAcreditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(235, 389);
            label2.Name = "label2";
            label2.Size = new Size(209, 21);
            label2.TabIndex = 62;
            label2.Text = "Seleccione lugar de atención";
            // 
            // cbxLugar
            // 
            cbxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLugar.FormattingEnabled = true;
            cbxLugar.Location = new Point(235, 413);
            cbxLugar.Margin = new Padding(3, 4, 3, 4);
            cbxLugar.Name = "cbxLugar";
            cbxLugar.Size = new Size(267, 28);
            cbxLugar.TabIndex = 61;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(45, 29);
            rbtNormal.Margin = new Padding(3, 4, 3, 4);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(83, 25);
            rbtNormal.TabIndex = 55;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtUrgencia
            // 
            rbtUrgencia.AutoSize = true;
            rbtUrgencia.Location = new Point(162, 31);
            rbtUrgencia.Margin = new Padding(3, 4, 3, 4);
            rbtUrgencia.Name = "rbtUrgencia";
            rbtUrgencia.Size = new Size(94, 25);
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
            groupBox2.Location = new Point(551, 388);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(288, 73);
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
            btnNuevaAcreditacion.Location = new Point(448, 507);
            btnNuevaAcreditacion.Margin = new Padding(3, 4, 3, 4);
            btnNuevaAcreditacion.Name = "btnNuevaAcreditacion";
            btnNuevaAcreditacion.Size = new Size(181, 37);
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
            pnlAcreditacion.Controls.Add(label2);
            pnlAcreditacion.Controls.Add(cbxLugar);
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
            pnlAcreditacion.Location = new Point(14, 16);
            pnlAcreditacion.Margin = new Padding(3, 4, 3, 4);
            pnlAcreditacion.Name = "pnlAcreditacion";
            pnlAcreditacion.Size = new Size(1137, 858);
            pnlAcreditacion.TabIndex = 65;
            // 
            // frmAcreditacionConsultorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 586);
            Controls.Add(pnlAcreditacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(66, 47);
            Name = "frmAcreditacionConsultorios";
            Text = "Acreditación";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlAcreditacion.ResumeLayout(false);
            pnlAcreditacion.PerformLayout();
            ResumeLayout(false);
        }

        private void frmAcreditacion_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Label label2;
        private ComboBox cbxLugar;
        private RadioButton rbtNormal;
        private RadioButton rbtUrgencia;
        private GroupBox groupBox2;
        private Button btnNuevaAcreditacion;
        private Panel pnlAcreditacion;
    }
}