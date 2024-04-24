using App;
using Controllers;


namespace Vista
{
    public class Register
    {
        private readonly AdministradorDeCredenciales _administradorCredenciales;
        private readonly AdministradorDeBD _administradorBD;
        private readonly Login _login;
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        private bool usuarioVerificado;
        public void PedirCredenciales()
        {
            try
            {
                if (usuarioVerificado)
                {
                    SolicitarContraseña();
                    VerificarContrasena();
                }
                else
                {
                    SolicitarUsuario();
                    if (NombreUsuario == "0")
                    {
                        Program program = new Program();
                        program.IniciarMenu();
                    }
                    VerificarNombreUsuario();
                    SolicitarContraseña();
                    VerificarContrasena();
                    
                }
                if (ConfirmarContrasena())
                {
                    if (_administradorBD.InsertarUsuarioSiNoExiste(NombreUsuario, Contraseña))
                    {
                        Console.WriteLine("Cuenta creada con éxito");
                        Thread.Sleep(2000);
                        Console.Clear();
                        _login.PedirCredenciales();
                    }
                    else
                    {
                        usuarioVerificado = false;
                        MostrarMensajeYPedirCredenciales("Ya existe un usuario con ese email");
                    }
                }
            }
            catch (IOException)
            {
                MostrarMensajeYPedirCredenciales("Error en el ingreso de datos, formato incorrecto");
            }
            
        }

        public void SolicitarUsuario()
        {
            Console.WriteLine("OUTATIME SIGN UP");
            Console.WriteLine("Ingrese 0 para regresar inicio");
            Console.Write("Ingrese su dirección de correo electrónico: ");
            NombreUsuario = Console.ReadLine();
        }

        public void SolicitarContraseña()
        {
            Console.Write("\nIngrese su contraseña: ");
            Contraseña = Console.ReadLine();
        }

        public void VerificarNombreUsuario()
        {
            if (!_administradorCredenciales.ElEmailEsValido(NombreUsuario))
            {
                MostrarMensajeYPedirCredenciales("El correo ingresado es inválido.");
            }

            if (_administradorBD.ExisteElUsuario(NombreUsuario))
            {
                MostrarMensajeYPedirCredenciales("Ya existe un usuario con ese correo");
            }
            usuarioVerificado = true;
        }

        public void VerificarContrasena()
        {
            if (!_administradorCredenciales.LaContraseñaEsValida(Contraseña, NombreUsuario))
            {
                MostrarMensajeYPedirCredenciales("La contraseña ingresada es inválida.");
            }
        }

        public bool ConfirmarContrasena()
        {
            Console.Write("\nConfirme contraseña: ");
            if (Contraseña != Console.ReadLine())
            {
                MostrarMensajeYPedirCredenciales("Las contraseñas no coinciden");
            }
            return true;
        }
        public void MostrarMensajeYPedirCredenciales(string mensaje)
        {
            Console.WriteLine(mensaje);
            Thread.Sleep(1500);
            Console.Clear();
            PedirCredenciales();
        }

        public Register()
        {
            _administradorCredenciales = new AdministradorDeCredenciales();
            _administradorBD = new AdministradorDeBD();
            _login = new Login();
        }

    }


}
