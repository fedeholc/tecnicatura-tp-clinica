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
            nroMatricula = new DataGridViewTextBoxColumn();
            nombreProfesional = new DataGridViewTextBoxColumn();
            apellidoProfesional = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            txtEspecialidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvProfesionales).BeginInit();
            SuspendLayout();
            // 
            // lblTituloA
            // 
            lblTituloA.AutoSize = true;
            lblTituloA.BackColor = Color.Transparent;
            lblTituloA.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloA.Location = new Point(74, 173);
            lblTituloA.Margin = new Padding(6, 0, 6, 0);
            lblTituloA.Name = "lblTituloA";
            lblTituloA.Size = new Size(401, 46);
            lblTituloA.TabIndex = 80;
            lblTituloA.Text = "Listado de Profesionales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(70, 410);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 78;
            label1.Text = "Seleccione Profesional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(70, 269);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(284, 32);
            label2.TabIndex = 76;
            label2.Text = "Especialidad Seleccionada";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(70, 239);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1198, 0);
            panel2.TabIndex = 74;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1126, 167);
            btnVolver.Margin = new Padding(6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 60);
            btnVolver.TabIndex = 73;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvProfesionales
            // 
            dtgvProfesionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvProfesionales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProfesionales.Columns.AddRange(new DataGridViewColumn[] { nroMatricula, nombreProfesional, apellidoProfesional, especialidad });
            dtgvProfesionales.Location = new Point(74, 460);
            dtgvProfesionales.Margin = new Padding(4, 2, 4, 2);
            dtgvProfesionales.Name = "dtgvProfesionales";
            dtgvProfesionales.RowHeadersWidth = 82;
            dtgvProfesionales.Size = new Size(778, 194);
            dtgvProfesionales.TabIndex = 81;
            dtgvProfesionales.CellContentClick += dtgvProfesionales_CellContentClick;
            dtgvProfesionales.SelectionChanged += dtgvProfesionales_SelectionChanged;
            // 
            // nroMatricula
            // 
            nroMatricula.HeaderText = "Nro. Matricula";
            nroMatricula.MinimumWidth = 10;
            nroMatricula.Name = "nroMatricula";
            nroMatricula.Width = 210;
            // 
            // nombreProfesional
            // 
            nombreProfesional.HeaderText = "Nombre";
            nombreProfesional.MinimumWidth = 10;
            nombreProfesional.Name = "nombreProfesional";
            nombreProfesional.Width = 147;
            // 
            // apellidoProfesional
            // 
            apellidoProfesional.HeaderText = "Apellido";
            apellidoProfesional.MinimumWidth = 10;
            apellidoProfesional.Name = "apellidoProfesional";
            apellidoProfesional.Width = 147;
            // 
            // especialidad
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            especialidad.DefaultCellStyle = dataGridViewCellStyle1;
            especialidad.HeaderText = "Especialidad";
            especialidad.MinimumWidth = 10;
            especialidad.Name = "especialidad";
            especialidad.Width = 189;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(78, 306);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(276, 39);
            txtEspecialidad.TabIndex = 82;
            // 
            // frmListadoProfesionales
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 882);
            Controls.Add(txtEspecialidad);
            Controls.Add(dtgvProfesionales);
            Controls.Add(lblTituloA);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(btnVolver);
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
        private DataGridViewTextBoxColumn nroMatricula;
        private DataGridViewTextBoxColumn nombreProfesional;
        private DataGridViewTextBoxColumn apellidoProfesional;
        private DataGridViewTextBoxColumn especialidad;
        private TextBox txtEspecialidad;
    }
}