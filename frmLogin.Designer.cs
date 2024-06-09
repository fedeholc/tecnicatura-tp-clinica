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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            btnSalir = new Button();
            cbxUsuarios = new ComboBox();
            btnIngresar = new Button();
            txtPass = new TextBox();
            lblUsuario = new Label();
            lblPassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(cbxUsuarios);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 325);
            panel1.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(452, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbxUsuarios
            // 
            cbxUsuarios.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxUsuarios.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUsuarios.FormattingEnabled = true;
            cbxUsuarios.Location = new Point(107, 249);
            cbxUsuarios.Name = "cbxUsuarios";
            cbxUsuarios.Size = new Size(140, 23);
            cbxUsuarios.TabIndex = 29;
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(340, 278);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(80, 30);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(280, 249);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(140, 23);
            txtPass.TabIndex = 4;
            txtPass.Text = "1234";
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblUsuario.Location = new Point(107, 231);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(48, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblPassword.Location = new Point(280, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 349);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbxUsuarios;
        private Button btnIngresar;
        private TextBox txtPass;
        private Label lblUsuario;
        private Label lblPassword;
        private Button btnSalir;
    }
}