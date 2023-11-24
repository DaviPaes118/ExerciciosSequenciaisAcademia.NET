namespace Quest8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.  Produto que tenha as propriedades Nome, Fabricante
            //(objeto da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo

            try
            {
                Fabricante fabricante = new Fabricante("Fábrica XYZ", "Rua A", "Cidade B");
                Produto produto = new Produto("Produto 1", fabricante, 50.0);

                Console.WriteLine($"Nome do Produto: {produto.Nome}");
                Console.WriteLine($"Nome do Fabricante: {produto.Fabricante.Nome}");
                Console.WriteLine($"Preço do Produto: {produto.Preco}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}