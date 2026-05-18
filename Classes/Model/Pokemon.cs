using System.Text.Json.Serialization;

public sealed class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("height")]
    public int Height { get; set; }
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
    [JsonPropertyName("abilities")] // this could potentially crash the program
    public List<PokemonAbilities> Abilities { get; set; } = new List<PokemonAbilities>();
    [JsonPropertyName("types")]
    public List<PokemonType> Types { get; set; } = new List<PokemonType>();
    [JsonPropertyName("stats")]
    public List<PokemonStat> Stats { get; set; } = new List<PokemonStat>();
    [JsonPropertyName("sprites")]
    public PokemonSprites Sprites { get; set; } = new PokemonSprites();
}

public sealed class PokemonAbilities
{
    [JsonPropertyName("ability")]
    public NamedApiResource Ability { get; set; } = new NamedApiResource();
    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
}

public sealed class PokemonType
{
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
    [JsonPropertyName("type")]
    public NamedApiResource Type { get; set; } = new NamedApiResource();
}

public sealed class PokemonStat
{
    [JsonPropertyName("base_stat")]
    public int BaseStat { get; set; }
    [JsonPropertyName("stat")]
    public NamedApiResource Stat { get; set; } = new NamedApiResource();
}

public sealed class PokemonSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}

public sealed class NamedApiResource
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}