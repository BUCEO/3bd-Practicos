using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class User
    {
        /*Nombre de Usuario*/
        public string Username { get; set; }

        /*E-Mail CORREO ELECTRÓNICO*/
        public string Email { get; set; }

        /*Conjunto de bytes para almacenar la Pass, hasheado con SHA-256*/
        public byte[] HashedPassword { get; set; }
    }
}