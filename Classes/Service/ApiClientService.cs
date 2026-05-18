using System.Net.Http.Json;
using System.Text.Json;
public sealed class ApiClientService
{
    private readonly HttpClient _client;
    private static readonly JsonSerializerOptions _options = new JsonSerializerOptions()
    {
        PropertyNameCaseInsensitive = true
    };

    public ApiClientService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<Meme>> GetMemesAsync(string url)
    {
        var response = await _client.GetFromJsonAsync<ImageModel>(url, _options);

        return response!.Data.Memes ?? [];
    }

    public async Task<Pokemon?> GetPokemonAsync(string nameOrId)
    {
        return await _client.GetFromJsonAsync<Pokemon>($"https://pokeapi.co/api/v2/pokemon/{nameOrId.ToLower()}", _options);
    }
}