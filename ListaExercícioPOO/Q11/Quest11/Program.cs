namespace Quest11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e outro para
            //frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).

            Carro meuCarro = new Carro("Fusca", 1975);

            meuCarro.Acelerar();
            Console.WriteLine($"Velocidade após acelerar: {meuCarro.ObterVelocidade()}");

            meuCarro.Frear();
            Console.WriteLine($"Velocidade após frear: {meuCarro.ObterVelocidade()}");

            meuCarro.Frear(); 
            Console.WriteLine($"Velocidade após tentativa de frear novamente: {meuCarro.ObterVelocidade()}");
        }
    }
}