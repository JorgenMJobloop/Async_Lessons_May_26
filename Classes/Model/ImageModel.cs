using System.Text.Json.Serialization;

public sealed class ImageModel
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
    [JsonPropertyName("data")]
    public ImageData Data { get; set; } = new ImageData();
}

public sealed class ImageData
{
    [JsonPropertyName("memes")]
    public List<Meme> Memes { get; set; } = new List<Meme>();
}

public sealed class Meme
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("width")]
    public int Width { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
    [JsonPropertyName("box_count")]
    public int BoxCount { get; set; }
}