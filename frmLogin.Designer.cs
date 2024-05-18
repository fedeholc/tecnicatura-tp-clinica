namespace clinica
{
    partial class frmLogin
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
            panel1 = new Panel();
            cbxUsuarios = new ComboBox();
            label1 = new Label();
            btnIngresar = new Button();
            txtPass = new TextBox();
            lblUsuario = new Label();
            lblPassword = new Label();
            btnSalir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(cbxUsuarios);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(87, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 241);
            panel1.TabIndex = 7;
            // 
            // cbxUsuarios
            // 
            cbxUsuarios.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxUsuarios.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUsuarios.FormattingEnabled = true;
            cbxUsuarios.Location = new Point(109, 109);
            cbxUsuarios.Name = "cbxUsuarios";
            cbxUsuarios.Size = new Size(156, 23);
            cbxUsuarios.TabIndex = 29;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(103, 49);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 5;
            label1.Text = "Ingreso al sistema";
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnIngresar.Location = new Point(288, 154);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 41);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(288, 109);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(144, 23);
            txtPass.TabIndex = 4;
            txtPass.Text = "1234";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(109, 91);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(288, 91);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(408, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmLoginRefact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 450);
            Controls.Add(panel1);
            Name = "frmLoginRefact";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbxUsuarios;
        private Label label1;
        private Button btnIngresar;
        private TextBox txtPass;
        private Label lblUsuario;
        private Label lblPassword;
        private Button btnSalir;
    }
}