using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login
{
    public partial class Form1 : Form
    {
        /*Lista de usuarios con diccionario*/
        private Dictionary<string, User> _users = new Dictionary<string, User>(); 

        public Form1()
        {
            InitializeComponent();

            using (SHA256 sha256 = SHA256.Create())
            {
                _users.Add
                (
                    "Fenix",
                    new User
                    {
                        Username = "Fenix",
                        Email = "fenix1916@gmail.com",
                        HashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes("fenix123"))
                    }
                );
                _users.Add
                (
                    "Nicolas",
                    new User
                    {
                        Username = "Nicolas",
                        Email = "nicoo@gmail.com",
                        HashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes("nicoos"))
                    }
                );
                _users.Add
                (
                    "NestorMozz",
                    new User
                    {
                        Username = "NestorMozz",
                        Email = "GerardoMozz@hotmail.com",
                        HashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes("nmozz"))
                    }
                );
                _users.Add
                (
                    "Ernesto",
                    new User
                    {
                        Username = "Ernesto",
                        Email = "ernestogomez@yahoo.com",
                        HashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes("ernesto2"))
                    }
                );
                _users.Add
                (
                    "Ricochet",
                    new User
                    {
                        Username = "Ricochet",
                        Email = "ricochet9@yahoo.com",
                        HashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes("riquil"))
                    }
                );
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_users.TryGetValue(txtUsername.Text, out User user))
            {
                byte[] pass;
                using (SHA256 sha256 = SHA256.Create())
                {
                    pass = sha256.ComputeHash(Encoding.UTF8.GetBytes(txtPass.Text));
                }

                if (user.HashedPassword.SequenceEqual(pass))
                {
                    Console.WriteLine("El usuario inicio sesión correctamente");
                }
                else
                {
                    Console.WriteLine("El usuario existe, pero la contraseña es incorrecta");
                }
            }
            else
            {
                Console.WriteLine("El usuario no se encuentra registrado");
            }
        }
    }
}
