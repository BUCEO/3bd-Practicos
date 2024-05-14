using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Gestion
{
    public class ListaUsuarios
    {
        public ListaUsuarios() 
        {
            List<Usuario> lista=new List<Usuario>();
            Lista = lista;
        }
        public List<Usuario> Lista {  get; set; }


        /*public bool AgregarUsuario(Usuario user)
          {
              if (Lista.Count()==0)
              {

                   List<Usuario> lista = new List<Usuario>();
                   lista = Lista;
                   lista.Add(user);
                   Lista = lista;
                   return true;

              }
              else
              {
                  foreach (Usuario u in Lista)
                  {
                      if (u.Email.Equals(user.Email))
                      {
                          return false;
                      }
                      else
                      {                       
                          List<Usuario> lista = new List<Usuario>();
                          lista = Lista;
                          lista.Add(user);
                          Lista = lista;
                          break;

                      }
                  }
                  return true;
              }
          }
        */

        public void AgregarUsuario(Usuario user)
        {
            if (Lista.Count() == 0)
            {

                List<Usuario> lista = new List<Usuario>();
                lista = Lista;
                lista.Add(user);
                Lista = lista;              
            }
            else
            {
                foreach (Usuario u in Lista)
                {
                    if (!u.Email.Equals(user.Email))
                    {                    
                        List<Usuario> lista = new List<Usuario>();
                        lista = Lista;
                        lista.Add(user);
                        Lista = lista;
                        break;
                    }
                }
            }
        }




        /*  public bool EliminarUsuario(string user)
           {
               foreach(Usuario u in Lista)
               {
                   if (u.Email.Equals(user))
                   {
                       List<Usuario> lista = new List<Usuario>();
                       lista = Lista;
                       lista.Remove(u);
                       Lista = lista;
                       return true;
                   }
               }
               return false;
           }
          */

        public void EliminarUsuario(string user)
        {
            if(Lista.Count()>0) {
                foreach (Usuario u in Lista)
                {
                    if (u.Email.Equals(user))
                    {
                        List<Usuario> lista = new List<Usuario>();
                        lista = Lista;
                        lista.Remove(u);
                        Lista = lista;
                    }
                }
            }
            
        }

        public bool ExisteUsuario(string user)
        {
            foreach (Usuario u in Lista)
            {
                if (u.Email.Equals(user))
                {
                    return true;
                }
            }
            return false; 
        }
        public Usuario BuscarUsuario(string user)
        {
            foreach (Usuario u in Lista)
            {
                if (u.Email.Equals(user))
                {
                   return u;
                }
            }
            Usuario usuarioinexistente = new Usuario();
            return usuarioinexistente;
        }
    }
}
