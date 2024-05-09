namespace Clinica
{
    partial class frmMenuPrincipal
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
            lblIngreso = new Label();
            btnSalir = new Button();
            btnInscripciones = new Button();
            panel1 = new Panel();
            btnAtencion = new Button();
            btnSalaDeEspera = new Button();
            btnAcreditacion = new Button();
            btnTurnos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 9);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(50, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Usuario:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(382, 305);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.FlatAppearance.BorderColor = Color.Black;
            btnInscripciones.FlatAppearance.BorderSize = 2;
            btnInscripciones.Font = new Font("Segoe UI", 12F);
            btnInscripciones.Location = new Point(90, 25);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(263, 30);
            btnInscripciones.TabIndex = 2;
            btnInscripciones.Text = "Registro de Pacientes";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAtencion);
            panel1.Controls.Add(btnSalaDeEspera);
            panel1.Controls.Add(btnAcreditacion);
            panel1.Controls.Add(btnTurnos);
            panel1.Controls.Add(btnInscripciones);
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 247);
            panel1.TabIndex = 6;
            // 
            // btnAtencion
            // 
            btnAtencion.FlatAppearance.BorderColor = Color.Black;
            btnAtencion.FlatAppearance.BorderSize = 2;
            btnAtencion.Font = new Font("Segoe UI", 12F);
            btnAtencion.Location = new Point(90, 197);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(263, 30);
            btnAtencion.TabIndex = 10;
            btnAtencion.Text = "Atención de Pacientes";
            btnAtencion.UseVisualStyleBackColor = true;
            btnAtencion.Click += btnAtencion_Click;
            // 
            // btnSalaDeEspera
            // 
            btnSalaDeEspera.FlatAppearance.BorderColor = Color.Black;
            btnSalaDeEspera.FlatAppearance.BorderSize = 2;
            btnSalaDeEspera.Font = new Font("Segoe UI", 12F);
            btnSalaDeEspera.Location = new Point(90, 154);
            btnSalaDeEspera.Name = "btnSalaDeEspera";
            btnSalaDeEspera.Size = new Size(263, 30);
            btnSalaDeEspera.TabIndex = 9;
            btnSalaDeEspera.Text = "Sala de Espera";
            btnSalaDeEspera.UseVisualStyleBackColor = true;
            btnSalaDeEspera.Click += btnSalaDeEspera_Click;
            // 
            // btnAcreditacion
            // 
            btnAcreditacion.FlatAppearance.BorderColor = Color.Black;
            btnAcreditacion.FlatAppearance.BorderSize = 2;
            btnAcreditacion.Font = new Font("Segoe UI", 12F);
            btnAcreditacion.Location = new Point(90, 111);
            btnAcreditacion.Name = "btnAcreditacion";
            btnAcreditacion.Size = new Size(263, 30);
            btnAcreditacion.TabIndex = 8;
            btnAcreditacion.Text = "Acreditación de Pacientes";
            btnAcreditacion.UseVisualStyleBackColor = true;
            btnAcreditacion.Click += btnAcreditacion_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderColor = Color.Black;
            btnTurnos.FlatAppearance.BorderSize = 2;
            btnTurnos.Font = new Font("Segoe UI", 12F);
            btnTurnos.Location = new Point(90, 68);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(263, 30);
            btnTurnos.TabIndex = 7;
            btnTurnos.Text = "Gestión de Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 341);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica - Menú Principal";
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnInscripciones;
        private Panel panel1;
        private Button btnTurnos;
        private Button btnAcreditacion;
        private Button btnSalaDeEspera;
        private Button btnAtencion;
    }
}