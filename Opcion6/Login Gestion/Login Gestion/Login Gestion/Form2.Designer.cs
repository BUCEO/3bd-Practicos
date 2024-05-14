namespace Login_Gestion
{
    partial class Form2
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            btnVer = new Button();
            mensaje = new Label();
            btnCrear = new Button();
            lblResultado = new Label();
            btnCrearCuenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 40);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 34);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(95, 98);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(166, 23);
            txtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(267, 97);
            btnVer.Margin = new Padding(3, 2, 3, 2);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(56, 24);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += button2_Click;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.Location = new Point(50, 7);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(227, 15);
            mensaje.TabIndex = 6;
            mensaje.Text = "Ingrese su dirección de correo electrónico";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(129, 167);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(82, 22);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Continuar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(95, 138);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "label3";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(129, 194);
            btnCrearCuenta.Margin = new Padding(3, 2, 3, 2);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(82, 22);
            btnCrearCuenta.TabIndex = 10;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 233);
            Controls.Add(btnCrearCuenta);
            Controls.Add(lblResultado);
            Controls.Add(btnCrear);
            Controls.Add(mensaje);
            Controls.Add(btnVer);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Crear cuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Label label2;
        private Button btnVer;
        private Label mensaje;
        private Button btnCrear;
        private Label lblResultado;
        private Button btnCrearCuenta;
    }
}