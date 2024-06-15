namespace clinica
{
    partial class frmSalaDeEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaDeEspera));
            btnVolver = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            lvwConTurno = new ListView();
            lvwSinTurno = new ListView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblTituloSDE = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1101, 556);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(65, 30);
            btnVolver.TabIndex = 42;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(171, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 1);
            panel2.TabIndex = 41;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1106, 33);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lvwConTurno
            // 
            lvwConTurno.Location = new Point(171, 136);
            lvwConTurno.Name = "lvwConTurno";
            lvwConTurno.Size = new Size(995, 175);
            lvwConTurno.TabIndex = 67;
            lvwConTurno.UseCompatibleStateImageBehavior = false;
            // 
            // lvwSinTurno
            // 
            lvwSinTurno.Location = new Point(171, 357);
            lvwSinTurno.Name = "lvwSinTurno";
            lvwSinTurno.Size = new Size(995, 175);
            lvwSinTurno.TabIndex = 68;
            lvwSinTurno.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 113);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 69;
            label1.Text = "Estudios con turno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 335);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 70;
            label2.Text = "Estudios sin turno";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTituloSDE);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lvwSinTurno);
            panel1.Controls.Add(lvwConTurno);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 648);
            panel1.TabIndex = 71;
            // 
            // lblTituloSDE
            // 
            lblTituloSDE.AutoSize = true;
            lblTituloSDE.BackColor = Color.Transparent;
            lblTituloSDE.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloSDE.Location = new Point(173, 35);
            lblTituloSDE.Name = "lblTituloSDE";
            lblTituloSDE.Size = new Size(123, 23);
            lblTituloSDE.TabIndex = 71;
            lblTituloSDE.Text = "Sala de espera";
            // 
            // frmSalaDeEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 667);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSalaDeEspera";
            Text = "Sala de Espera";
            Load += frmSalaDeEspera_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Panel panel2;
        private Button btnSalir;
        private ListView lvwConTurno;
        private ListView lvwSinTurno;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label lblTituloSDE;
    }
}