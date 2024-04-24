using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;


namespace Controllers
{
    public class AdministradorDeCredenciales
    {
        
        
        public string ConvertirStringEnHash(string contraseña)
        {
            int workFactor = 12;
            
            return BCrypt.Net.BCrypt.HashPassword(contraseña, workFactor);
        }
       
        

        public bool LaContraseñaEsValida(string contraseña, string nombreUsuario)
        {
            bool cumpleCondiciones = contraseña.Length > 8 &&
                              contraseña != nombreUsuario &&
                              contraseña.Any(char.IsUpper) &&
                              contraseña.Any(char.IsLower) &&
                              contraseña.Any(char.IsDigit) &&
                              contraseña.Any(character => char.IsSymbol(character) || char.IsPunctuation(character));

            return cumpleCondiciones;
        }

        public bool ElEmailEsValido(string nombreUsuario)
        {
            
            try
            { 
                var email = new MailAddress(nombreUsuario);
                return email.Address == nombreUsuario.Trim();
            }
            catch
            {
                return false;
            }
        }
        
        public AdministradorDeCredenciales()
        {

        }
    }
}
