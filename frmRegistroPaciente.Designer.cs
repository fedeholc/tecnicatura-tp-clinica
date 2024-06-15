namespace Clinica
{
    partial class frmRegistroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPaciente));
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblCobertura = new Label();
            btnInscribir = new Button();
            btnVolver = new Button();
            pnlRegistro = new Panel();
            btnImprimirComprobante = new Button();
            btnSalir = new Button();
            dtpFechaNac = new DateTimePicker();
            pnlTituloR = new Panel();
            lblTituloR = new Label();
            lblTel = new Label();
            txtTelefono = new TextBox();
            lblFecha = new Label();
            btnNuevaInscripcion = new Button();
            cbxCobertura = new ComboBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            labelApellido = new Label();
            txtApellido = new TextBox();
            pnlRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblNombre.Location = new Point(91, 172);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 192);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += validacionCamposString;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(325, 242);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(209, 23);
            txtDNI.TabIndex = 4;
            txtDNI.KeyPress += validacionCampoDNI;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblDNI.Location = new Point(325, 222);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(26, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 342);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEmail.Location = new Point(91, 322);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // lblCobertura
            // 
            lblCobertura.AutoSize = true;
            lblCobertura.BackColor = Color.Transparent;
            lblCobertura.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblCobertura.Location = new Point(325, 322);
            lblCobertura.Name = "lblCobertura";
            lblCobertura.Size = new Size(60, 15);
            lblCobertura.TabIndex = 7;
            lblCobertura.Text = "Cobertura";
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.ActiveCaption;
            btnInscribir.FlatAppearance.BorderColor = Color.LightGray;
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInscribir.Location = new Point(91, 390);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(149, 28);
            btnInscribir.TabIndex = 9;
            btnInscribir.Text = "Registrar Paciente";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(384, 451);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(149, 28);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pnlRegistro
            // 
            pnlRegistro.BackgroundImage = (Image)resources.GetObject("pnlRegistro.BackgroundImage");
            pnlRegistro.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRegistro.BorderStyle = BorderStyle.FixedSingle;
            pnlRegistro.Controls.Add(btnImprimirComprobante);
            pnlRegistro.Controls.Add(btnSalir);
            pnlRegistro.Controls.Add(dtpFechaNac);
            pnlRegistro.Controls.Add(pnlTituloR);
            pnlRegistro.Controls.Add(lblTituloR);
            pnlRegistro.Controls.Add(lblTel);
            pnlRegistro.Controls.Add(txtTelefono);
            pnlRegistro.Controls.Add(lblFecha);
            pnlRegistro.Controls.Add(btnVolver);
            pnlRegistro.Controls.Add(btnNuevaInscripcion);
            pnlRegistro.Controls.Add(cbxCobertura);
            pnlRegistro.Controls.Add(lblDireccion);
            pnlRegistro.Controls.Add(txtDireccion);
            pnlRegistro.Controls.Add(labelApellido);
            pnlRegistro.Controls.Add(txtApellido);
            pnlRegistro.Controls.Add(btnInscribir);
            pnlRegistro.Controls.Add(lblNombre);
            pnlRegistro.Controls.Add(txtNombre);
            pnlRegistro.Controls.Add(lblCobertura);
            pnlRegistro.Controls.Add(lblEmail);
            pnlRegistro.Controls.Add(txtDNI);
            pnlRegistro.Controls.Add(lblDNI);
            pnlRegistro.Controls.Add(txtEmail);
            pnlRegistro.Location = new Point(12, 12);
            pnlRegistro.Name = "pnlRegistro";
            pnlRegistro.Size = new Size(618, 546);
            pnlRegistro.TabIndex = 16;
            // 
            // btnImprimirComprobante
            // 
            btnImprimirComprobante.BackColor = SystemColors.ActiveCaption;
            btnImprimirComprobante.FlatAppearance.BorderColor = Color.LightGray;
            btnImprimirComprobante.FlatStyle = FlatStyle.Flat;
            btnImprimirComprobante.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnImprimirComprobante.Location = new Point(384, 390);
            btnImprimirComprobante.Name = "btnImprimirComprobante";
            btnImprimirComprobante.Size = new Size(149, 28);
            btnImprimirComprobante.TabIndex = 10;
            btnImprimirComprobante.Text = "Comprobante";
            btnImprimirComprobante.UseVisualStyleBackColor = false;
            btnImprimirComprobante.Click += btnImprimirComprobante_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(401, 32);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 28);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(91, 242);
            dtpFechaNac.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(209, 23);
            dtpFechaNac.TabIndex = 3;
            dtpFechaNac.Value = DateTime.Today;
            // 
            // pnlTituloR
            // 
            pnlTituloR.BorderStyle = BorderStyle.FixedSingle;
            pnlTituloR.Location = new Point(170, 65);
            pnlTituloR.Name = "pnlTituloR";
            pnlTituloR.Size = new Size(360, 1);
            pnlTituloR.TabIndex = 25;
            // 
            // lblTituloR
            // 
            lblTituloR.AutoSize = true;
            lblTituloR.BackColor = Color.Transparent;
            lblTituloR.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloR.Location = new Point(172, 35);
            lblTituloR.Name = "lblTituloR";
            lblTituloR.Size = new Size(76, 23);
            lblTituloR.TabIndex = 24;
            lblTituloR.Text = "Registro";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = Color.Transparent;
            lblTel.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblTel.Location = new Point(91, 272);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(52, 15);
            lblTel.TabIndex = 22;
            lblTel.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(91, 292);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(209, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += validacionCamposInt;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblFecha.Location = new Point(91, 222);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(116, 15);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "Fecha de nacimiento";
            // 
            // btnNuevaInscripcion
            // 
            btnNuevaInscripcion.BackColor = SystemColors.ActiveCaption;
            btnNuevaInscripcion.FlatAppearance.BorderColor = Color.LightGray;
            btnNuevaInscripcion.FlatStyle = FlatStyle.Flat;
            btnNuevaInscripcion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNuevaInscripcion.Location = new Point(91, 451);
            btnNuevaInscripcion.Name = "btnNuevaInscripcion";
            btnNuevaInscripcion.Size = new Size(149, 28);
            btnNuevaInscripcion.TabIndex = 11;
            btnNuevaInscripcion.Text = "Nueva Inscripción";
            btnNuevaInscripcion.UseVisualStyleBackColor = false;
            btnNuevaInscripcion.Click += btnNuevaInscripcion_Click;
            // 
            // cbxCobertura
            // 
            cbxCobertura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCobertura.FormattingEnabled = true;
            cbxCobertura.ItemHeight = 15;
            cbxCobertura.Location = new Point(325, 342);
            cbxCobertura.Name = "cbxCobertura";
            cbxCobertura.Size = new Size(209, 23);
            cbxCobertura.TabIndex = 8;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblDireccion.Location = new Point(325, 272);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(55, 15);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(325, 292);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(209, 23);
            txtDireccion.TabIndex = 6;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.BackColor = Color.Transparent;
            labelApellido.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            labelApellido.Location = new Point(325, 172);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(50, 15);
            labelApellido.TabIndex = 15;
            labelApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(325, 192);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(209, 23);
            txtApellido.TabIndex = 2;
            txtApellido.KeyPress += validacionCamposString;
            // 
            // frmRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 570);
            Controls.Add(pnlRegistro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistroPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica - Registro de Pacientes";
            FormClosed += frmRegistroPaciente_FormClosed;
            Load += frmInscripcion_Load;
            pnlRegistro.ResumeLayout(false);
            pnlRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCobertura;
        private Button btnInscribir;
        private Button btnVolver;
        private Panel pnlRegistro;
        private Button btnNuevaInscripcion;
        private Label labelApellido;
        private TextBox txtApellido;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private ComboBox cbxCobertura;
        private Label lblTel;
        private TextBox txtTelefono;
        private Label lblFecha;
        private Label lblTituloR;
        private Panel pnlTituloR;
        private DateTimePicker dtpFechaNac;
        private Button btnSalir;
        private Button btnImprimirComprobante;
    }
}