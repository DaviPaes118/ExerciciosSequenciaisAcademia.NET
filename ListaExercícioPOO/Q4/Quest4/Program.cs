namespace Quest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome, telefone, e-mail). Implemente um construtor e métodos para adicionar numa lista, remover e
            //buscar contatos.

            AgendaTelefonica agenda = new AgendaTelefonica();

            agenda.AddContato("João", "123456789", "joao@example.com");
            agenda.AddContato("Maria", "987654321", "maria@example.com");

            agenda.BuscarContato("João");

            agenda.RemoverContato("Maria");

            agenda.BuscarContato("Maria");
        }
    }
}