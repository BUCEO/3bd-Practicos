using Vista;

namespace App
{
    public class Program
    {
        private readonly Login _login;
        private readonly Register _register;
        static void Main(string[] args)
        {
            Program mainObj = new Program();
            mainObj.IniciarMenu();
        }

        public void IniciarMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Sistema OUTATIME");
                Console.WriteLine("______________________");
                Console.WriteLine("Ingrese una opcion:");
                Console.WriteLine("______________________");
                Console.WriteLine("1. LOGIN !! 2.REGISTER:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Program program = new Program(new Login());
                        program._login.PedirCredenciales();
                        break;

                    case 2:
                        Program prog = new Program(new Register());
                        prog._register.PedirCredenciales();
                        break;

                    default:
                        Console.WriteLine("Opcion invalida, vuelva a elegir");
                        Thread.Sleep(1000);
                        Console.Clear();
                        IniciarMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opcion invalida, vuelva a elegir");
                Thread.Sleep(1000);
                Console.Clear();
                IniciarMenu();
            }
            
        }
        public Program(Register register)
        {
            _register = register;
        }
        public Program(Login login)
        {
            _login = login;
        }

        public Program()
        {

        }
    }
}