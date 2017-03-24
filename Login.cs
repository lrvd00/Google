using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            TextWriter escritor = System.Console.Out;
            TextReader leitor = System.Console.In;
            StreamReader sr = new StreamReader(@"C:\\senha.txt");
            string usuario;
            string senha;
            string user;
            string password;

            usuario = sr.ReadLine();
            senha = sr.ReadLine();

            do
            {
                user = leitor.ReadLine();
                password = leitor.ReadLine();

                if (!usuario.Equals(user) && !senha.Equals(password))
                {
                    Console.WriteLine("Usuario e senha iválidos");
                }
                else if (!usuario.Equals(user))
                {
                    Console.WriteLine("Usuario inválido");
                }
                else if (!senha.Equals(password))
                {
                    Console.WriteLine("Senha inválida");
                }
            } while (!usuario.Equals(user) || !senha.Equals(password));
            
            Console.ReadKey();
        }
    }
}
