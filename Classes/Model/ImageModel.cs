public class ImageModel
{
    public bool Success { get; set; }
    public Dictionary<string, Memes[]> Data { get; set; } = new Dictionary<string, Memes[]>();
}

public class Memes
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int BoxCount { get; set; }
}