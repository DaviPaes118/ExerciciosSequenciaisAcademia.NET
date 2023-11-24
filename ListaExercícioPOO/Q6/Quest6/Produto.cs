using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest6
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QtdEstoque { get; set; }

        public Produto(int codigo, string nome, double preco, int qtdEstoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nome: {Nome}, Preço: {Preco}, Quantidade em Estoque: {QtdEstoque}";
        }
    }
}
