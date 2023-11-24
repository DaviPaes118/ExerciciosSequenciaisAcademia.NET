namespace Quest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código. 

            GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

            Produto produto1 = new Produto(1, "Produto A", 10.50, 20);
            Produto produto2 = new Produto(2, "Produto B", 15.75, 15);

            gerenciador.AddProduto(produto1);
            gerenciador.AddProduto(produto2);

            gerenciador.ListarProdutos();

            int codigoConsulta = 1;
            Produto produtoConsultado = gerenciador.ConsultarProdutoPorCodigo(codigoConsulta);

            if (produtoConsultado != null)
            {
                Console.WriteLine($"\nProduto encontrado:\n{produtoConsultado}");
            }
            else
            {
                Console.WriteLine($"\nProduto com código {codigoConsulta} não encontrado.");
            }
        }
    }
}