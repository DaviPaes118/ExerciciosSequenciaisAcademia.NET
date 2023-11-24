using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest8
{
    internal class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do fabricante não pode ser vazio ou nulo.");
                }
                nome = value;
            }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
        }
    }
}
