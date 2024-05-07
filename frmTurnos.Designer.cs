namespace clinica
{
    partial class frmTurnos
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
            cbxEstudios = new ComboBox();
            btnSalir = new Button();
            cbxHoraDesde = new ComboBox();
            cbxHoraHasta = new ComboBox();
            lblEstudio = new Label();
            dtpFechaDesde = new DateTimePicker();
            dtpFechaHasta = new DateTimePicker();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            lbxTurnos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            grbMostrarTurnos = new GroupBox();
            rbtOcupados = new RadioButton();
            rbtDisponibles = new RadioButton();
            cbxPaciente = new ComboBox();
            label3 = new Label();
            btnRegistrarPaciente = new Button();
            btnCancelar = new Button();
            panel2 = new Panel();
            btnAsignar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grbMostrarTurnos.SuspendLayout();
            SuspendLayout();
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(48, 111);
            cbxEstudios.Name = "cbxEstudios";
            cbxEstudios.Size = new Size(250, 23);
            cbxEstudios.TabIndex = 0;
            cbxEstudios.SelectedIndexChanged += cbxEstudios_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(814, 500);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbxHoraDesde
            // 
            cbxHoraDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHoraDesde.FormattingEnabled = true;
            cbxHoraDesde.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            cbxHoraDesde.Location = new Point(48, 282);
            cbxHoraDesde.Name = "cbxHoraDesde";
            cbxHoraDesde.Size = new Size(84, 23);
            cbxHoraDesde.TabIndex = 3;
            cbxHoraDesde.SelectedIndexChanged += cbxHoraDesde_SelectedIndexChanged;
            // 
            // cbxHoraHasta
            // 
            cbxHoraHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHoraHasta.FormattingEnabled = true;
            cbxHoraHasta.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            cbxHoraHasta.Location = new Point(138, 282);
            cbxHoraHasta.Name = "cbxHoraHasta";
            cbxHoraHasta.Size = new Size(84, 23);
            cbxHoraHasta.TabIndex = 4;
            cbxHoraHasta.SelectedIndexChanged += cbxHoraHasta_SelectedIndexChanged;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.Location = new Point(48, 93);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(46, 15);
            lblEstudio.TabIndex = 6;
            lblEstudio.Text = "Estudio";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Location = new Point(48, 168);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(250, 23);
            dtpFechaDesde.TabIndex = 7;
            dtpFechaDesde.ValueChanged += dtpFechaDesde_ValueChanged;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Location = new Point(48, 224);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(250, 23);
            dtpFechaHasta.TabIndex = 8;
            dtpFechaHasta.ValueChanged += dtpFechaHasta_ValueChanged;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(48, 150);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(73, 15);
            lblFechaDesde.TabIndex = 9;
            lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new Point(48, 206);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(71, 15);
            lblFechaHasta.TabIndex = 10;
            lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lbxTurnos
            // 
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 15;
            lbxTurnos.Location = new Point(350, 91);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(539, 334);
            lbxTurnos.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 264);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 12;
            label1.Text = "Hora desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 264);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 13;
            label2.Text = "Hora hasta";
            // 
            // grbMostrarTurnos
            // 
            grbMostrarTurnos.Controls.Add(rbtOcupados);
            grbMostrarTurnos.Controls.Add(rbtDisponibles);
            grbMostrarTurnos.Location = new Point(47, 320);
            grbMostrarTurnos.Name = "grbMostrarTurnos";
            grbMostrarTurnos.Size = new Size(251, 51);
            grbMostrarTurnos.TabIndex = 26;
            grbMostrarTurnos.TabStop = false;
            grbMostrarTurnos.Text = "Mostrar turnos:";
            // 
            // rbtOcupados
            // 
            rbtOcupados.AutoSize = true;
            rbtOcupados.Location = new Point(137, 21);
            rbtOcupados.Name = "rbtOcupados";
            rbtOcupados.Size = new Size(79, 19);
            rbtOcupados.TabIndex = 1;
            rbtOcupados.Text = "Ocupados";
            rbtOcupados.UseVisualStyleBackColor = true;
            rbtOcupados.CheckedChanged += rbtOcupados_CheckedChanged;
            // 
            // rbtDisponibles
            // 
            rbtDisponibles.AutoSize = true;
            rbtDisponibles.Checked = true;
            rbtDisponibles.Location = new Point(21, 21);
            rbtDisponibles.Name = "rbtDisponibles";
            rbtDisponibles.Size = new Size(86, 19);
            rbtDisponibles.TabIndex = 0;
            rbtDisponibles.TabStop = true;
            rbtDisponibles.Text = "Disponibles";
            rbtDisponibles.UseVisualStyleBackColor = true;
            rbtDisponibles.CheckedChanged += rbtDisponibles_CheckedChanged;
            // 
            // cbxPaciente
            // 
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(48, 402);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(251, 23);
            cbxPaciente.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 383);
            label3.Name = "label3";
            label3.Size = new Size(214, 15);
            label3.TabIndex = 29;
            label3.Text = "Seleccionar Paciente para asignar turno";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(146, 431);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(153, 23);
            btnRegistrarPaciente.TabIndex = 30;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(707, 439);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(182, 23);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar turno";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(48, 479);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 1);
            panel2.TabIndex = 28;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(519, 439);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(182, 23);
            btnAsignar.TabIndex = 32;
            btnAsignar.Text = "Asignar turno";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(47, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 1);
            panel1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(47, 10);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 33;
            label4.Text = "Gestión de turnos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 65);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 34;
            label5.Text = "Listado de turnos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(48, 59);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 35;
            label6.Text = "Filtrar turnos";
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 537);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnAsignar);
            Controls.Add(panel2);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(label3);
            Controls.Add(cbxPaciente);
            Controls.Add(grbMostrarTurnos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxTurnos);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(dtpFechaHasta);
            Controls.Add(dtpFechaDesde);
            Controls.Add(lblEstudio);
            Controls.Add(cbxHoraHasta);
            Controls.Add(cbxHoraDesde);
            Controls.Add(btnSalir);
            Controls.Add(cbxEstudios);
            Name = "frmTurnos";
            Text = "frmTurnos";
            Load += frmTurnos_Load;
            grbMostrarTurnos.ResumeLayout(false);
            grbMostrarTurnos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxEstudios;
        private Button btnSalir;
        private ComboBox cbxHoraDesde;
        private ComboBox cbxHoraHasta;
        private Label lblEstudio;
        private DateTimePicker dtpFechaDesde;
        private DateTimePicker dtpFechaHasta;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private ListBox lbxTurnos;
        private Label label1;
        private Label label2;
        private GroupBox grbMostrarTurnos;
        private RadioButton rbtOcupados;
        private RadioButton rbtDisponibles;
        private ComboBox cbxPaciente;
        private Label label3;
        private Button btnRegistrarPaciente;
        private Button btnCancelar;
        private Panel panel2;
        private Button btnAsignar;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}