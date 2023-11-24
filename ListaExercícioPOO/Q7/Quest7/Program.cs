namespace Quest7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora. Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma
            //string para armazenar o dono da playlist. Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da
            //música). Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.

            Playlist minhaPlaylist = new Playlist("Eu");

            Musica musica1 = new Musica("Psychosocial", "Slipknot", "Roadrunner, Nuclear Blast");
            Musica musica2 = new Musica("Dead but Pretty", "IC3PEAK", "IC3PEAK");
            Musica musica3 = new Musica("Andromeda", "GHOSTMANE", "GHOSTMANE");
            Musica musica4 = new Musica("Paris", "$uicideboy$", "G * 59 Caroline");
            Musica musica5 = new Musica("Can You Feel My Heart", "Bring Me The Horizon", "Sony, RCA, Epitaph");

            minhaPlaylist.AdicionarMusica(musica1);
            minhaPlaylist.AdicionarMusica(musica2);
            minhaPlaylist.AdicionarMusica(musica3);
            minhaPlaylist.AdicionarMusica(musica4);
            minhaPlaylist.AdicionarMusica(musica5);

            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();

        }
    }
}