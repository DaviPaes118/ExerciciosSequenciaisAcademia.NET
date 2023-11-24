using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest11
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int Velocidade { get; set; }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0; // Inicializa a velocidade como 0.
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            if (Velocidade >= 10)
            {
                Velocidade -= 10;
            }
            else
            {
                Velocidade = 0;
            }
        }

        public int ObterVelocidade()
        {
            return Velocidade;
        }
    }
}
