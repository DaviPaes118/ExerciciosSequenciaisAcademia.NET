using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest5
{
    internal class GerenciadorDeTarefas
    {
        public class Tarefa
        {
            public string Descricao { get; set; }
            public DateTime DataVencimento { get; set; }
        }

        public List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa
            {
                Descricao = descricao,
                DataVencimento = dataVencimento
            };

            tarefas.Add(novaTarefa);
        }

        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefaParaRemover = tarefas.Find(tarefa => tarefa.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));

            if (tarefaParaRemover != null)
            {
                tarefas.Remove(tarefaParaRemover);
                Console.WriteLine($"Tarefa '{descricao}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa '{descricao}' não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            if (tarefas.Count > 0)
            {
                Console.WriteLine("Lista de Tarefas:");
                foreach (var tarefa in tarefas)
                {
                    Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
            }
        }

        public bool TarefaDeveSerExecutadaHoje(Tarefa tarefa)
        {
            return tarefa.DataVencimento.Date == DateTime.Today;
        }
    }
}
