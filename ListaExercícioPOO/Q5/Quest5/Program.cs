namespace Quest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento). Implemente um construtor e métodos para adicionar,
            //remover e listar tarefas. Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje.

            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            gerenciador.AdicionarTarefa("Limpar a casa", DateTime.Parse("2023-11-06"));
            gerenciador.AdicionarTarefa("Fazer compras", DateTime.Parse("2023-11-07"));

            gerenciador.ListarTarefas();

            gerenciador.RemoverTarefa("Fazer compras");

            gerenciador.ListarTarefas();

            Console.WriteLine("Tarefas para hoje:");
            foreach (var tarefa in gerenciador.tarefas)
            {
                if (gerenciador.TarefaDeveSerExecutadaHoje(tarefa))
                {
                    Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                }
            }
        }
    }
}