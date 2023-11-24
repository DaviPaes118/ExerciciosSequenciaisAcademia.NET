namespace Quest9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.

            try
            {
                Livro livro = new Livro("Ordem Paranormal: Iniciação", "Rafael 'Cellbit' Lange ");

                Console.WriteLine($"Título do Livro: {livro.Titulo}");
                Console.WriteLine($"Autor do Livro: {livro.Autor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}