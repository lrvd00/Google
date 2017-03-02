using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Funcionarios
    {
        private string nome;
        private int idade;
        private string email;
        private Cargos cargo;
        private Unidades unidade;

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

        internal Cargos Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }
    }
}
