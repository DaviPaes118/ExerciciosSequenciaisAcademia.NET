using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest12
{
    public class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa novaPessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(novaPessoa);
        }

        public void RemovePessoa(string nome)
        {
            pessoas.RemoveAll(p => p.Nome == nome);
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
