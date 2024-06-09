namespace Clinica
{
    partial class frmConexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            panel2 = new Panel();
            txtPuerto = new TextBox();
            label7 = new Label();
            txtServidor = new TextBox();
            label5 = new Label();
            txtBD = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnConectar = new Button();
            txtPasswordBD = new TextBox();
            label3 = new Label();
            txtUsuarioBD = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.Location = new Point(452, 19);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 37);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtPuerto);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtServidor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtBD);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnConectar);
            panel2.Controls.Add(txtPasswordBD);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUsuarioBD);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(17, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 267);
            panel2.TabIndex = 8;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(439, 101);
            txtPuerto.Margin = new Padding(3, 4, 3, 4);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(164, 27);
            txtPuerto.TabIndex = 11;
            txtPuerto.Text = "3306";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 77);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 10;
            label7.Text = "Puerto";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(238, 101);
            txtServidor.Margin = new Padding(3, 4, 3, 4);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(164, 27);
            txtServidor.TabIndex = 9;
            txtServidor.Text = "localhost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 77);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 6;
            label5.Text = "Base de Datos";
            // 
            // txtBD
            // 
            txtBD.Location = new Point(33, 101);
            txtBD.Margin = new Padding(3, 4, 3, 4);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(164, 27);
            txtBD.TabIndex = 8;
            txtBD.Text = "Clinica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 77);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 7;
            label6.Text = "Servidor";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(385, 40);
            label2.TabIndex = 5;
            label2.Text = "Conexión a la Base de Datos";
            // 
            // btnConectar
            // 
            btnConectar.BackColor = SystemColors.ActiveCaption;
            btnConectar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnConectar.Location = new Point(452, 178);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(152, 37);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtPasswordBD
            // 
            txtPasswordBD.Location = new Point(238, 188);
            txtPasswordBD.Margin = new Padding(3, 4, 3, 4);
            txtPasswordBD.Name = "txtPasswordBD";
            txtPasswordBD.Size = new Size(164, 27);
            txtPasswordBD.TabIndex = 4;
            txtPasswordBD.Text = "1234";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 164);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Usuario";
            // 
            // txtUsuarioBD
            // 
            txtUsuarioBD.Location = new Point(33, 188);
            txtUsuarioBD.Margin = new Padding(3, 4, 3, 4);
            txtUsuarioBD.Name = "txtUsuarioBD";
            txtUsuarioBD.Size = new Size(164, 27);
            txtUsuarioBD.TabIndex = 3;
            txtUsuarioBD.Text = "root";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 164);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // frmConexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 300);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalir;
        private Panel panel2;
        private Label label2;
        private Button btnConectar;
        private TextBox txtPasswordBD;
        private Label label3;
        private TextBox txtUsuarioBD;
        private Label label4;
        private TextBox txtPuerto;
        private Label label7;
        private TextBox txtServidor;
        private Label label5;
        private TextBox txtBD;
        private Label label6;
    }
} 