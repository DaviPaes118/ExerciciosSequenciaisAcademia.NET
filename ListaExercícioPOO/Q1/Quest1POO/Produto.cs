using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest1POO
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QtdEstoque { get; private set; }


        public Produto(string nome, double preco, int qtdEstoque ) 
        { 
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }


        public void AddEstoque( int qtd )
        {
            if ( qtd > 0 )
            {
                QtdEstoque += qtd;  
            }
            else { Console.WriteLine("A quantidade deve ser maior que zero."); }
        }


        public void RemoverEstoque(int qtd)
        {
            if (qtd > 0 && qtd <= QtdEstoque)
            {
                QtdEstoque -= qtd;
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Não é possível remover do estoque.");
            }
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade em estoque: {QtdEstoque}");
        }
    }
}
