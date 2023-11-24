namespace Quest12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
            //void armazenaPessoa(String nome, int idade, float altura);
            //void removePessoa(String nome);
            //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
            //Faça um menu para navegar entre as opções infinitamente.

            Agenda minhaAgenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Armazenar Pessoa");
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Buscar Pessoa");
                Console.WriteLine("4 - Imprimir Agenda");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());

                        minhaAgenda.ArmazenaPessoa(nome, idade, altura);
                        break;

                    case 2:
                        Console.Write("Nome: ");
                        string nomeRemover = Console.ReadLine();
                        minhaAgenda.RemovePessoa(nomeRemover);
                        break;

                    case 3:
                        Console.Write("Nome: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = minhaAgenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine(pessoaEncontrada);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;

                    case 4:
                        minhaAgenda.ImprimeAgenda();
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