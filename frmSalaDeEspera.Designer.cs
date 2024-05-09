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
            btnVolver = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            lvwConTurno = new ListView();
            lvwSinTurno = new ListView();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(594, 368);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 42;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(141, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 1);
            panel2.TabIndex = 41;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(513, 368);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lvwConTurno
            // 
            lvwConTurno.Location = new Point(22, 40);
            lvwConTurno.Name = "lvwConTurno";
            lvwConTurno.Size = new Size(647, 120);
            lvwConTurno.TabIndex = 67;
            lvwConTurno.UseCompatibleStateImageBehavior = false;
            lvwConTurno.SelectedIndexChanged += lvwConTurno_SelectedIndexChanged;
            // 
            // lvwSinTurno
            // 
            lvwSinTurno.Location = new Point(22, 201);
            lvwSinTurno.Name = "lvwSinTurno";
            lvwSinTurno.Size = new Size(647, 120);
            lvwSinTurno.TabIndex = 68;
            lvwSinTurno.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(253, 20);
            label1.TabIndex = 69;
            label1.Text = "Sala de espera - Estudios con turno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 178);
            label2.Name = "label2";
            label2.Size = new Size(248, 20);
            label2.TabIndex = 70;
            label2.Text = "Sala de espera - Estudios sin turno";
            // 
            // frmSalaDeEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 414);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwSinTurno);
            Controls.Add(lvwConTurno);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSalaDeEspera";
            Text = "Sala de Espera";
            Load += frmSalaDeEspera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Panel panel2;
        private Button btnSalir;
        private ListView lvwConTurno;
        private ListView lvwSinTurno;
        private Label label1;
        private Label label2;
    }
}