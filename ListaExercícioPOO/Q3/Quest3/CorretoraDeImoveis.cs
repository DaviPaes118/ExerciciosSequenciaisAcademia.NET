using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest3
{
    internal class CorretoraDeImoveis
    {
        public string Endereco { get; private set; }
        public double Preco { get; private set; }
        public string Tipo { get; private set; }

        private static List<CorretoraDeImoveis> imoveis = new List<CorretoraDeImoveis>();

        public CorretoraDeImoveis(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        public static void ListarImoveis()
        {
            foreach (var imovel in imoveis)
            {
                Console.WriteLine($"Endereço: {imovel.Endereco}");
                Console.WriteLine($"Preço: R${imovel.Preco}");
                Console.WriteLine($"Tipo: {imovel.Tipo}");
            }
        }

        public static double CalcularValorMedio()
        {
            double soma = 0;

            foreach (var imovel in imoveis)
            {
                soma += imovel.Preco;
            }

            return imoveis.Count > 0 ? soma / imoveis.Count : 0;
        }

        public static void InserirImovel(CorretoraDeImoveis imovel)
        {
            imoveis.Add(imovel);
        }

        public static void AlterarPreco(string endereco, double novoPreco)
        {
            foreach (var imovel in imoveis)
            {
                if (imovel.Endereco == endereco)
                {
                    imovel.Preco = novoPreco;
                    Console.WriteLine($"O preço do imóvel no endereço {endereco} foi atualizado para R${novoPreco}");
                    return;
                }
            }

            Console.WriteLine($"Imóvel no endereço {endereco} não encontrado.");
        }
    }
}
