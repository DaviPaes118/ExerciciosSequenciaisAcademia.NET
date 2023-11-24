namespace Quest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe RegistroDeCompras com atributos para registrar informações de compras (data, produto, valor). Implemente um construtor e métodos para adicionar e listar
            //compras.

            RegistroDeCompras compra1 = new RegistroDeCompras(new DateTime(2023, 11, 10), "Produto A", 50.0);
            RegistroDeCompras compra2 = new RegistroDeCompras(new DateTime(2023, 11, 11), "Produto B", 30.0);

            RegistroDeCompras registro = new RegistroDeCompras(new DateTime(2023, 11, 10), "Produto A", 50.0);

            registro.AddCompra(compra1);
            registro.AddCompra(compra2);

            registro.ListarCompras();
        }
    }
}