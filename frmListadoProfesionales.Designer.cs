namespace clinica
{
    partial class frmListadoProfesionales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTituloA = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnVolver = new Button();
            dtgvProfesionales = new DataGridView();
            txtEspecialidad = new TextBox();
            Id_Profesional = new DataGridViewTextBoxColumn();
            nombreProfesional = new DataGridViewTextBoxColumn();
            apellidoProfesional = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvProfesionales).BeginInit();
            SuspendLayout();
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(46, 108);
            lblTituloA.Margin = new Padding(4, 0, 4, 0);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(255, 29);
            lblTituloA.TabIndex = 80;
            lblTituloA.Text = "Listado de Profesionales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(43, 256);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 78;
            label1.Text = "Seleccione Profesional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(43, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 21);
            label2.TabIndex = 76;
            label2.Text = "Especialidad Seleccionada";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(43, 149);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 1);
            panel2.TabIndex = 74;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(629, 104);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 37);
            btnVolver.TabIndex = 73;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvProfesionales
            // 
            dtgvProfesionales.AllowUserToAddRows = false;
            dtgvProfesionales.AllowUserToDeleteRows = false;
            dtgvProfesionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvProfesionales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProfesionales.Columns.AddRange(new DataGridViewColumn[] { Id_Profesional, nombreProfesional, apellidoProfesional, especialidad });
            dtgvProfesionales.Location = new Point(46, 288);
            dtgvProfesionales.Margin = new Padding(2, 1, 2, 1);
            dtgvProfesionales.Name = "dtgvProfesionales";
            dtgvProfesionales.ReadOnly = true;
            dtgvProfesionales.RowHeadersWidth = 82;
            dtgvProfesionales.Size = new Size(581, 121);
            dtgvProfesionales.TabIndex = 81;
            dtgvProfesionales.CellContentClick += dtgvProfesionales_CellContentClick;
            dtgvProfesionales.SelectionChanged += dtgvProfesionales_SelectionChanged;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(48, 191);
            txtEspecialidad.Margin = new Padding(2);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(171, 27);
            txtEspecialidad.TabIndex = 82;
            txtEspecialidad.TextChanged += txtEspecialidad_TextChanged;
            // 
            // Id_Profesional
            // 
            Id_Profesional.DataPropertyName = "Id_Profesional";
            Id_Profesional.HeaderText = "Id_Profesional";
            Id_Profesional.MinimumWidth = 10;
            Id_Profesional.Name = "Id_Profesional";
            Id_Profesional.ReadOnly = true;
            Id_Profesional.Width = 131;
            // 
            // nombreProfesional
            // 
            nombreProfesional.DataPropertyName = "nombreProfesional";
            nombreProfesional.HeaderText = "Nombre";
            nombreProfesional.MinimumWidth = 10;
            nombreProfesional.Name = "nombreProfesional";
            nombreProfesional.ReadOnly = true;
            nombreProfesional.Width = 93;
            // 
            // apellidoProfesional
            // 
            apellidoProfesional.DataPropertyName = "apellidoProfesional";
            apellidoProfesional.HeaderText = "Apellido";
            apellidoProfesional.MinimumWidth = 10;
            apellidoProfesional.Name = "apellidoProfesional";
            apellidoProfesional.ReadOnly = true;
            apellidoProfesional.Width = 95;
            // 
            // especialidad
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            especialidad.DefaultCellStyle = dataGridViewCellStyle1;
            especialidad.HeaderText = "Especialidad";
            especialidad.MinimumWidth = 10;
            especialidad.Name = "especialidad";
            especialidad.ReadOnly = true;
            especialidad.Width = 122;
            // 
            // frmListadoProfesionales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 551);
            Controls.Add(txtEspecialidad);
            Controls.Add(dtgvProfesionales);
            Controls.Add(lblTituloA);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(btnVolver);
            Margin = new Padding(2);
            Name = "frmListadoProfesionales";
            Text = "frmListadoProfesionales";
            Load += frmListadoProfesionales_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProfesionales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloA;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button btnVolver;
        private DataGridView dtgvProfesionales;
        private TextBox txtEspecialidad;
        private DataGridViewTextBoxColumn Id_Profesional;
        private DataGridViewTextBoxColumn nombreProfesional;
        private DataGridViewTextBoxColumn apellidoProfesional;
        private DataGridViewTextBoxColumn especialidad;
    }
}