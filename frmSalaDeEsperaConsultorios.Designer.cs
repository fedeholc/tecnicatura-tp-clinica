
namespace clinica
{
    partial class frmSalaDeEsperaConsultorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaDeEsperaConsultorios));
            btnVolver = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            lvwConTurno = new ListView();
            lvwSinTurno = new ListView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            listView1 = new ListView();
            lblTituloSDE = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1183, 741);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 37);
            btnVolver.TabIndex = 42;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(195, 87);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 1);
            panel2.TabIndex = 41;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1183, 42);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 37);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lvwConTurno
            // 
            lvwConTurno.Location = new Point(207, 120);
            lvwConTurno.Margin = new Padding(3, 4, 3, 4);
            lvwConTurno.Name = "lvwConTurno";
            lvwConTurno.Size = new Size(1128, 131);
            lvwConTurno.TabIndex = 67;
            lvwConTurno.UseCompatibleStateImageBehavior = false;
            lvwConTurno.SelectedIndexChanged += lvwConTurno_SelectedIndexChanged;
            // 
            // lvwSinTurno
            // 
            lvwSinTurno.Location = new Point(207, 283);
            lvwSinTurno.Margin = new Padding(3, 4, 3, 4);
            lvwSinTurno.Name = "lvwSinTurno";
            lvwSinTurno.Size = new Size(1125, 145);
            lvwSinTurno.TabIndex = 68;
            lvwSinTurno.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 92);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 69;
            label1.Text = "Kinesiológia\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 255);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 70;
            label2.Text = "Salud Mental";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(lblTituloSDE);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lvwSinTurno);
            panel1.Controls.Add(lvwConTurno);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(10, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1471, 863);
            panel1.TabIndex = 71;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(207, 440);
            label3.Name = "label3";
            label3.Size = new Size(56, 24);
            label3.TabIndex = 73;
            label3.Text = "Otros";
            // 
            // listView1
            // 
            listView1.Location = new Point(207, 468);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1125, 145);
            listView1.TabIndex = 72;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTituloSDE
            // 
            lblTituloSDE.AutoSize = true;
            lblTituloSDE.BackColor = Color.Transparent;
            lblTituloSDE.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloSDE.Location = new Point(198, 47);
            lblTituloSDE.Name = "lblTituloSDE";
            lblTituloSDE.Size = new Size(284, 29);
            lblTituloSDE.TabIndex = 71;
            lblTituloSDE.Text = "Sala de espera consultorios";
            // 
            // frmSalaDeEsperaConsultorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 889);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSalaDeEsperaConsultorios";
            Text = "Sala de Espera Consultorios";
            Load += frmSalaDeEsperaConsultorios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvwConTurno;
        private System.Windows.Forms.ListView lvwSinTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloSDE;
        private Label label3;
        private ListView listView1;
    }
}
