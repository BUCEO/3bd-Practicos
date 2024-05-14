namespace Login_Gestion
{
    partial class Form1
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
            lblTipoUsuario = new Label();
            chkAdmin = new CheckBox();
            chkInvitado = new CheckBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            lblResultado = new Label();
            lblEstadoinicio = new Label();
            btnIniciar = new Button();
            btnVer = new Button();
            btnCrearUsuario = new Button();
            SuspendLayout();
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(11, 13);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(91, 15);
            lblTipoUsuario.TabIndex = 0;
            lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new Point(117, 12);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(102, 19);
            chkAdmin.TabIndex = 1;
            chkAdmin.Text = "Administrador";
            chkAdmin.UseVisualStyleBackColor = true;
            chkAdmin.CheckedChanged += chkAdmin_CheckedChanged;
            // 
            // chkInvitado
            // 
            chkInvitado.AutoSize = true;
            chkInvitado.Location = new Point(225, 12);
            chkInvitado.Name = "chkInvitado";
            chkInvitado.Size = new Size(69, 19);
            chkInvitado.TabIndex = 2;
            chkInvitado.Text = "Invitado";
            chkInvitado.UseVisualStyleBackColor = true;
            chkInvitado.CheckedChanged += chkInvitado_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(122, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 48);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Correo Electrónico";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(6, 119);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(123, 116);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(122, 23);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 160);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(122, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "El email es incorrecto.";
            // 
            // lblEstadoinicio
            // 
            lblEstadoinicio.AutoSize = true;
            lblEstadoinicio.Location = new Point(12, 187);
            lblEstadoinicio.Name = "lblEstadoinicio";
            lblEstadoinicio.Size = new Size(100, 15);
            lblEstadoinicio.TabIndex = 9;
            lblEstadoinicio.Text = "Inicio de sesión ...";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(117, 210);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(96, 23);
            btnIniciar.TabIndex = 10;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(251, 115);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(56, 24);
            btnVer.TabIndex = 11;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(117, 238);
            btnCrearUsuario.Margin = new Padding(3, 2, 3, 2);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(96, 23);
            btnCrearUsuario.TabIndex = 12;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 272);
            Controls.Add(btnCrearUsuario);
            Controls.Add(btnVer);
            Controls.Add(btnIniciar);
            Controls.Add(lblEstadoinicio);
            Controls.Add(lblResultado);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(chkInvitado);
            Controls.Add(chkAdmin);
            Controls.Add(lblTipoUsuario);
            Name = "Form1";
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoUsuario;
        private CheckBox chkAdmin;
        private CheckBox chkInvitado;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Label lblResultado;
        private Label lblEstadoinicio;
        private Button btnIniciar;
        private Button btnVer;
        private Button btnCrearUsuario;
    }
}
