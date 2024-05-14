using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace Login_Gestion
{
    public partial class Form1 : Form
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

        public static ListaUsuarios listaUsuarios = new ListaUsuarios();
        public Form1()
        {
            InitializeComponent();
            lblResultado.Visible = false;
            lblEstadoinicio.Visible = false;
            lblContrase�a.Visible = false;
            txtContrase�a.Visible = false;
            txtContrase�a.PasswordChar = '�';
            btnCrearUsuario.Visible = false;
            btnVer.Visible = false;

            Usuario admin = new Usuario("admin@gmail.com", "admin1234");
            listaUsuarios.AgregarUsuario(admin);

        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            lblEstadoinicio.Visible = false;


            if (verificadorEmail(txtEmail.Text))
            {
                if (chkInvitado.Checked)
                {
                    lblEstadoinicio.Text = "Inicio de sesi�n exitoso";
                    lblEstadoinicio.Visible = true;
                    Usuario invitado = new Usuario(txtEmail.Text, "");
                }
                else
                {
                    if (listaUsuarios.ExisteUsuario(txtEmail.Text))
                    {
                        if ((listaUsuarios.BuscarUsuario(txtEmail.Text).Contrase�a).Equals(txtContrase�a.Text))
                        {
                            lblEstadoinicio.Visible = true;
                            lblEstadoinicio.Text = "Inicio de sesi�n exitoso";
                            btnCrearUsuario.Visible = true;
                        }
                        else
                        {
                            lblResultado.Visible = true;
                            lblResultado.Text = "La contrase�a es incorrecta";
                        }
                    }
                    else
                    {
                        lblResultado.Text = "El usuario no existe";
                        lblResultado.Visible = true;
                    }
                }
            }
            else
            {
                lblResultado.Text = "El email es incorrecto.";
                lblResultado.Visible = true;
            }

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (btnVer.Text == "Ver")
            {
                btnVer.Text = "Ocultar";
                txtContrase�a.PasswordChar = '\0';
            }
            else
            {
                btnVer.Text = "Ver";
                txtContrase�a.PasswordChar = '�';
            }

        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblEstadoinicio.Text = "";
            if (chkAdmin.Checked) { chkInvitado.Checked = false; }
            txtContrase�a.Visible = true;
            lblContrase�a.Visible = true;
            btnVer.Visible = true;
        }

        private void chkInvitado_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblEstadoinicio.Text = "";
            if (chkInvitado.Checked) { chkAdmin.Checked = false; }
            txtContrase�a.Visible = false;
            lblContrase�a.Visible = false;
            btnVer.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            lblResultado.Text = "";
            lblEstadoinicio.Text = "";
            txtEmail.Text = "";
            txtContrase�a.Text = "";
            btnCrearUsuario.Visible = false;

        }
    }
}
