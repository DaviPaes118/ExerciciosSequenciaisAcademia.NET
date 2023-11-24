using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    internal class RegistroDeCompras
    {
        public DateTime Data { get; private set; }
        public string Produto { get; private set; }
        public double Valor { get; private set; }

        private List<RegistroDeCompras> compras = new List<RegistroDeCompras>();

        public RegistroDeCompras(DateTime data, string produto, double valor)
        {
            Data = data;
            Produto = produto;
            Valor = valor;
        }

        public void AddCompra(RegistroDeCompras compra)
        {
            compras.Add(compra);
        }

        public void ListarCompras()
        {
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.Data}");
                Console.WriteLine($"Produto: {compra.Produto}");
                Console.WriteLine($"Valor: R${compra.Valor}");
            }
        }
    }
}
