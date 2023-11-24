namespace Quest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo). Implemente um construtor e métodos para listar imóveis
            //disponíveis e calcular o valor médio.
            //Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.Insira os imoveis numa lista para facilitar o trabalho.

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço");
                Console.WriteLine("3. Listar Imóveis");
                Console.WriteLine("4. Calcular Valor Médio");
                Console.WriteLine("0. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o endereço do imóvel:");
                        string endereco = Console.ReadLine();

                        Console.WriteLine("Digite o preço do imóvel:");
                        double preco = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo do imóvel:");
                        string tipo = Console.ReadLine();

                        CorretoraDeImoveis.InserirImovel(new CorretoraDeImoveis(endereco, preco, tipo));
                        break;

                    case 2:
                        Console.WriteLine("Digite o endereço do imóvel que deseja alterar o preço: ");
                        string enderecoParaAlterar = Console.ReadLine();

                        Console.WriteLine("Digite o novo preço: ");
                        double novoPreco = double.Parse(Console.ReadLine());

                        CorretoraDeImoveis.AlterarPreco(enderecoParaAlterar, novoPreco);
                        break;

                    case 3:
                        CorretoraDeImoveis.ListarImoveis();
                        break;

                    case 4:
                        Console.WriteLine($"O valor médio dos imóveis é de R${CorretoraDeImoveis.CalcularValorMedio()}");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
