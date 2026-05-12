namespace Async_Lesson;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new CustomHttpClient();

        try
        {
            await client.GetDataAsync("https://api.imgflip.com/get_memes");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured when trying to fetch a resource remotely online! {e.Message}");
        }
    }
}
