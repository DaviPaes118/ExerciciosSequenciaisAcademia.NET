using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest4
{
    class AgendaTelefonica
    {
        class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
        }

        private List<Contato> contatos = new List<Contato>();

        public void AddContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Email = email
            };

            contatos.Add(novoContato);
        }

        public void RemoverContato(string nome)
        {
            Contato contatoParaRemover = contatos.Find(contato => contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (contatoParaRemover != null)
            {
                contatos.Remove(contatoParaRemover);
                Console.WriteLine($"Contato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
        }

        public void BuscarContato(string nome)
        {
            List<Contato> contatosEncontrados = contatos.FindAll(contato => contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (contatosEncontrados.Count > 0)
            {
                Console.WriteLine("Contatos encontrados:");
                foreach (var contato in contatosEncontrados)
                {
                    Console.WriteLine($"Nome: {contato.Nome}");
                    Console.WriteLine($"Telefone: {contato.Telefone}");
                    Console.WriteLine($"Email: {contato.Email}");
                }
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
        }
    }
}
