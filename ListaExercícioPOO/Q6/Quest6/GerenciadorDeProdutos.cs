using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest6
{
    public class GerenciadorDeProdutos
    {
        private List<Produto> produtos = new List<Produto>();

        public void AddProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        public Produto ConsultarProdutoPorCodigo(int codigo)
        {
            return produtos.Find(produto => produto.Codigo == codigo);
        }
    }
}
