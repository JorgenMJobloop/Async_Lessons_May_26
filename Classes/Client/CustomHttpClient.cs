using System.Net.Http.Json;
using System.Net.Sockets;
using System.Text.Json;

public class CustomHttpClient : ICustomHttpClient
{
    public async Task GetDataAsync(string url)
    {
        try
        {
            using HttpClient client = new HttpClient();
            var data = await client.GetFromJsonAsync<ImageModel>(url);
            Console.WriteLine(data!.Data.Memes.Count());
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"An error occured: {e.Message}");
        }
    }

    public async Task GetAsync(string url)
    {
        try
        {
            using HttpClient client = new HttpClient();
            var data = await client.GetStringAsync(url);

            Console.WriteLine(data);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"An error occured: {e.Message}");
        }
    }

    public Task GetDataByIdAsync(string url, int id)
    {
        try
        {
            using HttpClient client = new HttpClient();
            var data = client.GetStringAsync($"{url}/{id}");
            Console.WriteLine(data);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"A error occured: {e.Message}");
        }
        return Task.CompletedTask;
    }

    public Task PostDataAsync(string url, Dictionary<string, string> data)
    {
        throw new NotImplementedException();
    }
}