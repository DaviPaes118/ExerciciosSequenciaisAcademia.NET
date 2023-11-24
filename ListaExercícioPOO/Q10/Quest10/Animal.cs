using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest10
{
    internal class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public string EmitirSom()
        {
            switch (Especie.ToLower())
            {
                case "cachorro":
                    return "Au au!";
                case "gato":
                    return "Miau!";
                case "pássaro":
                    return "Piu piu!";
                default:
                    return "O animal não emite um som característico.";
            }
        }
    }
}
