using Controllers;
using BD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;

namespace Vista
{
    public class Login
    {
        private readonly AdministradorDeCredenciales _administradorCredenciales;
        private readonly AdministradorDeBD _administradorBD;
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        
        public void PedirCredenciales()
        {
            try
            {
                Console.WriteLine("OUTATIME LOGIN");
                Console.WriteLine("Ingrese 0 para regresar inicio");
                Console.Write("Ingrese su nombre de usuario: ");
                NombreUsuario = Console.ReadLine();
                if (NombreUsuario == "0")
                {
                    Program program = new Program();
                    program.IniciarMenu();
                }
                Console.Write("\nIngrese su contraseña: ");
                Contraseña = Console.ReadLine();
                if (!ElLoginEsValido())
                {
                    MostrarMensajeYPedirCredenciales("Nombre de usuario y/o contraseña inválido");
                }
                else
                {
                    Console.WriteLine($"\nBienvenido {NombreUsuario}");
                    SolicitarComando();
                }
            }
            catch (IOException)
            {
                MostrarMensajeYPedirCredenciales("Error en el ingreso de datos, formato incorrecto");
            }

        }

        

        public bool ElLoginEsValido()
        {
            if (!_administradorCredenciales.ElEmailEsValido(NombreUsuario) 
                && !_administradorCredenciales.LaContraseñaEsValida(Contraseña, NombreUsuario))
            {
                return false;
            }
            else
            {
                return _administradorBD.ExisteElUsuarioYLaContraseñaEsCorrecta(NombreUsuario, Contraseña);
            }
        }

        public void MostrarMensajeYPedirCredenciales(string mensaje)
        {
            Console.WriteLine(mensaje);
            Thread.Sleep(1000);
            Console.Clear();
            PedirCredenciales();
        }

        public void SolicitarComando()
        {
            Console.Write("Ingrese comando:");
            if(Console.ReadLine().ToLower().Equals("logout"))
            {
                Console.WriteLine("Cerrando sesión");
                Program program = new Program();
                Console.Clear();
                program.IniciarMenu();
            }
            else
            {
                Console.WriteLine("Comando inválido");
                SolicitarComando();
            }

        }
        public Login()
        {
            _administradorCredenciales = new AdministradorDeCredenciales();
            _administradorBD = new AdministradorDeBD();
        }
        
    }
}
