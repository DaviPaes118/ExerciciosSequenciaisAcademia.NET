using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest7
{
    internal class Playlist
    {
        private List<Musica> musicas = new List<Musica>();
        public string Dono { get; set; }

        public Playlist(string dono)
        {
            Dono = dono;
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void TocarMusicaAleatoria()
        {
            if (musicas.Count == 0)
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas para tocar.");
                return;
            }

            Random random = new Random();
            int indiceAleatorio = random.Next(0, musicas.Count);

            Musica musicaTocada = musicas[indiceAleatorio];
            Console.WriteLine($"Tocando: {musicaTocada}");
        }
    }
}
