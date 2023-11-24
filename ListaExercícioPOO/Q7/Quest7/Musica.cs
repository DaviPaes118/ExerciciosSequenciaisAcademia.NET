using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest7
{
    internal class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }

        public override string ToString()
        {
            return $"{Nome} - {Autor} ({Gravadora})";
        }
    }
}
