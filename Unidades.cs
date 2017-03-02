using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Unidades
    {
        private string cidade;
        private string estado;
        private string pais;

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }
    }
}
