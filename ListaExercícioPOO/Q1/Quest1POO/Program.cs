using System.Reflection.Metadata;

namespace Quest1POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe Produto com atributos como nome, preço e quantidade em estoque. Implemente um construtor e métodos para adicionar e remover itens do estoque.

            Produto produto1 = new Produto("Produto A", 10.0, 50);

            produto1.ExibirInfo();

            produto1.AddEstoque(20);

            produto1.ExibirInfo();

            produto1.RemoverEstoque(5);

            produto1.ExibirInfo();
        }
    }
}