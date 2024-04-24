using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Controllers
{
    public class AdministradorDeBD 
    {
        private readonly DBContext _context;
        private readonly AdministradorDeCredenciales _credenciales;

        public AdministradorDeBD()
        {
            _context = new DBContext();
            _credenciales = new AdministradorDeCredenciales();
        }
        
        public bool ExisteElUsuarioYLaContraseñaEsCorrecta(string nombreUsuario, string contraseña)
        {
            var usuario = _context.Users.FirstOrDefault(u => u.Nombre == nombreUsuario);
            
            if (usuario != null)
            {
                if(LaContraseñaCorrespondeAlHash(contraseña, usuario.Contraseña))
                {
                    return true;
                }                
            }
            return false;
        }


        public bool LaContraseñaCorrespondeAlHash(string contraseña, string hashContraseña)
        {
           
            return BCrypt.Net.BCrypt.Verify(contraseña, hashContraseña);
        }
        

        public bool InsertarUsuarioSiNoExiste(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Nombre == username);
            int lastUserId = _context.Users.OrderByDescending(u => u.Id).Select(u => u.Id).FirstOrDefault();

            if (user == null)
            {
                Usuario usuario = new Usuario()
                {
                    Id = lastUserId + 1,
                    Nombre = username,
                    Contraseña = _credenciales.ConvertirStringEnHash(password),
                    TipoUsuario = "regular"
                };

                _context.Users.Add(usuario);
                _context.SaveChanges();

                return true;
            }
            return false;
        }
        public bool ExisteElUsuario(string usuario)
        {
            var user = _context.Users.FirstOrDefault(u => u.Nombre ==  usuario);
            if(user == null)
            {
                return false;
            }
            return true;
        }
        


    }
}
