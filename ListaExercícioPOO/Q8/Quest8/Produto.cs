using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest8
{
    internal class Produto
    {
        private string nome;
        private Fabricante fabricante;
        private double preco;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
                }
                nome = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço do produto deve ser um valor positivo.");
                }
                preco = value;
            }
        }

        public Produto(string nome, Fabricante fabricante, double preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preco = preco;
        }
    }
}
