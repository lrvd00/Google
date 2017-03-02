using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Cargos
    {
        private string nome;
        private int salario;
        private int hierarquia;

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

        public int Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public int Hierarquia
        {
            get
            {
                return hierarquia;
            }

            set
            {
                hierarquia = value;
            }
        }
    }
}
