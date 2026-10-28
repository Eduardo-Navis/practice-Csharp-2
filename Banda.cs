class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome {get; set;}

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia() 
    {
        Console.Writeline($"Discografia da banda: {Nome}");
        foreatch (Album album in albums)
        {
            Console.Writeline($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
    
}