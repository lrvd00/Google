using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Apps
    {
        private string nome;
        private int tamanho;
        private int numDownloads;
        private int avaliacao;

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

        public int Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        public int NumDownloads
        {
            get
            {
                return numDownloads;
            }

            set
            {
                numDownloads = value;
            }
        }

        public int Avaliacao
        {
            get
            {
                return avaliacao;
            }

            set
            {
                avaliacao = value;
            }
        }
    }
}
