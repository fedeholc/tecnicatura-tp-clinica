
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnos));
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
            btnAsignar = new Button();
            pnlTituloT = new Panel();
            lblTituloT = new Label();
            label5 = new Label();
            btnVolver = new Button();
            pnlTurnos = new Panel();
            grbMostrarTurnos.SuspendLayout();
            pnlTurnos.SuspendLayout();
            SuspendLayout();
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(212, 122);
            cbxEstudios.Margin = new Padding(3, 4, 3, 4);
            cbxEstudios.Name = "cbxEstudios";
            cbxEstudios.Size = new Size(285, 27);
            cbxEstudios.TabIndex = 0;
            cbxEstudios.SelectedIndexChanged += cbxEstudios_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1112, 33);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
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
            cbxHoraDesde.Location = new Point(212, 329);
            cbxHoraDesde.Margin = new Padding(3, 4, 3, 4);
            cbxHoraDesde.Name = "cbxHoraDesde";
            cbxHoraDesde.Size = new Size(95, 27);
            cbxHoraDesde.TabIndex = 3;
            cbxHoraDesde.SelectedIndexChanged += cbxHoraDesde_SelectedIndexChanged;
            // 
            // cbxHoraHasta
            // 
            cbxHoraHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHoraHasta.FormattingEnabled = true;
            cbxHoraHasta.Items.AddRange(new object[] { "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "23:59" });
            cbxHoraHasta.Location = new Point(315, 329);
            cbxHoraHasta.Margin = new Padding(3, 4, 3, 4);
            cbxHoraHasta.Name = "cbxHoraHasta";
            cbxHoraHasta.Size = new Size(95, 27);
            cbxHoraHasta.TabIndex = 4;
            cbxHoraHasta.SelectedIndexChanged += cbxHoraHasta_SelectedIndexChanged;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.BackColor = Color.Transparent;
            lblEstudio.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEstudio.Location = new Point(211, 103);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(46, 15);
            lblEstudio.TabIndex = 6;
            lblEstudio.Text = "Estudio";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Location = new Point(212, 184);
            dtpFechaDesde.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(285, 27);
            dtpFechaDesde.TabIndex = 7;
            dtpFechaDesde.ValueChanged += dtpFechaDesde_ValueChanged;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Location = new Point(212, 255);
            dtpFechaHasta.Margin = new Padding(3, 4, 3, 4);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(285, 27);
            dtpFechaHasta.TabIndex = 8;
            dtpFechaHasta.ValueChanged += dtpFechaHasta_ValueChanged;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.BackColor = Color.Transparent;
            lblFechaDesde.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblFechaDesde.Location = new Point(212, 162);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(73, 15);
            lblFechaDesde.TabIndex = 9;
            lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.BackColor = Color.Transparent;
            lblFechaHasta.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblFechaHasta.Location = new Point(212, 232);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(72, 15);
            lblFechaHasta.TabIndex = 10;
            lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lbxTurnos
            // 
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 19;
            lbxTurnos.Location = new Point(557, 122);
            lbxTurnos.Margin = new Padding(3, 4, 3, 4);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(615, 422);
            lbxTurnos.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(212, 306);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 12;
            label1.Text = "Hora desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(315, 306);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 13;
            label2.Text = "Hora hasta";
            // 
            // grbMostrarTurnos
            // 
            grbMostrarTurnos.BackColor = Color.Transparent;
            grbMostrarTurnos.Controls.Add(rbtOcupados);
            grbMostrarTurnos.Controls.Add(rbtDisponibles);
            grbMostrarTurnos.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbMostrarTurnos.Location = new Point(211, 377);
            grbMostrarTurnos.Margin = new Padding(3, 4, 3, 4);
            grbMostrarTurnos.Name = "grbMostrarTurnos";
            grbMostrarTurnos.Padding = new Padding(3, 4, 3, 4);
            grbMostrarTurnos.Size = new Size(287, 65);
            grbMostrarTurnos.TabIndex = 26;
            grbMostrarTurnos.TabStop = false;
            grbMostrarTurnos.Text = "Mostrar turnos:";
            // 
            // rbtOcupados
            // 
            rbtOcupados.AutoSize = true;
            rbtOcupados.Location = new Point(157, 27);
            rbtOcupados.Margin = new Padding(3, 4, 3, 4);
            rbtOcupados.Name = "rbtOcupados";
            rbtOcupados.Size = new Size(78, 19);
            rbtOcupados.TabIndex = 1;
            rbtOcupados.Text = "Ocupados";
            rbtOcupados.UseVisualStyleBackColor = true;
            rbtOcupados.CheckedChanged += rbtOcupados_CheckedChanged;
            // 
            // rbtDisponibles
            // 
            rbtDisponibles.AutoSize = true;
            rbtDisponibles.Checked = true;
            rbtDisponibles.Location = new Point(24, 27);
            rbtDisponibles.Margin = new Padding(3, 4, 3, 4);
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
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(212, 481);
            cbxPaciente.Margin = new Padding(3, 4, 3, 4);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(286, 27);
            cbxPaciente.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label3.Location = new Point(212, 457);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 29;
            label3.Text = "Seleccionar paciente para asignar turno";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.FlatAppearance.BorderColor = Color.LightGray;
            btnRegistrarPaciente.FlatStyle = FlatStyle.Flat;
            btnRegistrarPaciente.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarPaciente.Location = new Point(347, 516);
            btnRegistrarPaciente.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(150, 30);
            btnRegistrarPaciente.TabIndex = 30;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCancelar.Location = new Point(930, 563);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 30);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar turno";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.FlatAppearance.BorderColor = Color.LightGray;
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAsignar.Location = new Point(755, 563);
            btnAsignar.Margin = new Padding(3, 4, 3, 4);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(150, 30);
            btnAsignar.TabIndex = 32;
            btnAsignar.Text = "Asignar turno";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // pnlTituloT
            // 
            pnlTituloT.BorderStyle = BorderStyle.FixedSingle;
            pnlTituloT.ForeColor = SystemColors.ActiveBorder;
            pnlTituloT.Location = new Point(211, 65);
            pnlTituloT.Margin = new Padding(3, 4, 3, 4);
            pnlTituloT.Name = "pnlTituloT";
            pnlTituloT.Size = new Size(962, 1);
            pnlTituloT.TabIndex = 29;
            // 
            // lblTituloT
            // 
            lblTituloT.AutoSize = true;
            lblTituloT.BackColor = Color.Transparent;
            lblTituloT.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloT.Location = new Point(211, 35);
            lblTituloT.Name = "lblTituloT";
            lblTituloT.Size = new Size(147, 23);
            lblTituloT.TabIndex = 33;
            lblTituloT.Text = "Gestión de turnos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label5.Location = new Point(557, 103);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 34;
            label5.Text = "Listado de turnos";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1107, 563);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(65, 30);
            btnVolver.TabIndex = 36;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pnlTurnos
            // 
            pnlTurnos.BackgroundImage = (Image)resources.GetObject("pnlTurnos.BackgroundImage");
            pnlTurnos.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnos.Controls.Add(btnVolver);
            pnlTurnos.Controls.Add(label5);
            pnlTurnos.Controls.Add(lblTituloT);
            pnlTurnos.Controls.Add(pnlTituloT);
            pnlTurnos.Controls.Add(btnAsignar);
            pnlTurnos.Controls.Add(btnCancelar);
            pnlTurnos.Controls.Add(btnRegistrarPaciente);
            pnlTurnos.Controls.Add(label3);
            pnlTurnos.Controls.Add(cbxPaciente);
            pnlTurnos.Controls.Add(grbMostrarTurnos);
            pnlTurnos.Controls.Add(label2);
            pnlTurnos.Controls.Add(label1);
            pnlTurnos.Controls.Add(lbxTurnos);
            pnlTurnos.Controls.Add(lblFechaHasta);
            pnlTurnos.Controls.Add(lblFechaDesde);
            pnlTurnos.Controls.Add(dtpFechaHasta);
            pnlTurnos.Controls.Add(dtpFechaDesde);
            pnlTurnos.Controls.Add(lblEstudio);
            pnlTurnos.Controls.Add(cbxHoraHasta);
            pnlTurnos.Controls.Add(cbxHoraDesde);
            pnlTurnos.Controls.Add(btnSalir);
            pnlTurnos.Controls.Add(cbxEstudios);
            pnlTurnos.Location = new Point(12, 12);
            pnlTurnos.Name = "pnlTurnos";
            pnlTurnos.Size = new Size(1281, 642);
            pnlTurnos.TabIndex = 37;
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1308, 667);
            Controls.Add(pnlTurnos);
            DoubleBuffered = true;
            Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTurnos";
            Text = "frmTurnos";
            Load += frmTurnos_Load;
            grbMostrarTurnos.ResumeLayout(false);
            grbMostrarTurnos.PerformLayout();
            pnlTurnos.ResumeLayout(false);
            pnlTurnos.PerformLayout();
            ResumeLayout(false);
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
        private Button btnAsignar;
        private Panel pnlTituloT;
        private Label lblTituloT;
        private Label label5;
        private Button btnVolver;
        private Panel pnlTurnos;
    }
}