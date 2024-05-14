using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Gestion
{
    public partial class Form2 : Form
    {
        static bool verificadorEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
       
        public Form2()
        {
            InitializeComponent();
            label2.Visible = false;
            txtContraseña.Visible = false;
            lblResultado.Visible = false;
            btnVer.Visible = false;
            btnCrearCuenta.Visible = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnVer.Text == "Ver")
            {
                btnVer.Text = "Ocultar";
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                btnVer.Text = "Ver";
                txtContraseña.PasswordChar = '·';
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            if (verificadorEmail(txtEmail.Text) && !Form1.listaUsuarios.ExisteUsuario(txtEmail.Text))
            {
                label2.Visible = true;
                txtContraseña.Visible = true;
                btnVer.Visible = true;
                btnCrearCuenta.Visible = true;
                btnCrear.Visible = false;
                

            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Error con el Email.";

            }
            


        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Email = txtEmail.Text;
            if (user.ComprobadorDeContrasenia(txtContraseña.Text))
            {
                Usuario usuario = new Usuario(txtEmail.Text, txtContraseña.Text);
                Form1.listaUsuarios.AgregarUsuario(usuario);
                lblResultado.Visible = true;
                lblResultado.Text = "Usuario creado exitosamente.";
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Contraseña no válida.";
            }
        }
    }
}
