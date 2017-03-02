using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Usuarios
    {
        private string nome;
        private int idade;
        private string email;
        private string senha;
        private int celular;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public int Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
