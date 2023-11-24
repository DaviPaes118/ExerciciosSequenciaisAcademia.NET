namespace Quest10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado EmitirSom, que imprime na tela o som do animal.

            Animal meuAnimal = new Animal("Amora", "Cachorro", 5);

            Console.WriteLine($"Nome: {meuAnimal.Nome}");
            Console.WriteLine($"Espécie: {meuAnimal.Especie}");
            Console.WriteLine($"Idade: {meuAnimal.Idade}");

            string som = meuAnimal.EmitirSom();
            Console.WriteLine($"Som do animal: {som}");
        }
    }
}