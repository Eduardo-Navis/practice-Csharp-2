class Album
{
    private List<Musica> musicas = new List<Musica>();
    // usando o objeto musica, e declarando que é uma lista deles

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        // usa o objeto Musica também pra criar uma musica
        musicas.Add(musica);

    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }

        Console.WriteLine($"\nPara ouvir este álbum completo você precisa de: {DuracaoTotal}s");
    }
}