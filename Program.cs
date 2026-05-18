namespace Async_Lesson;

using Spectre.Console;
class Program
{
    static async Task Main(string[] args)
    {
        // var client = new CustomHttpClient();

        // try
        // {
        //     await client.GetAsync("https://pokeapi.co/api/v2/pokemon/2");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine($"An error occured when trying to fetch a resource remotely online! {e.Message}");
        // }

        var client = new HttpClient();
        var apiClientService = new ApiClientService(client);
        var cli = new CLI();

        AnsiConsole.MarkupLine("[bold green]Fetching memes...[/]");
        var memes = await apiClientService.GetMemesAsync("https://api.imgflip.com/get_memes");
        cli.DisplayMemes(memes);

        AnsiConsole.MarkupLine("[bold yellow]Fetching Pokémon data...[/]");

        // get user input using Spectre.Console
        var pokemonName = AnsiConsole.Ask<string>("Which Pokémon would you like to learn more about? (name/id)");
        var pokemon = await apiClientService.GetPokemonAsync(pokemonName);

        if (pokemon is null)
        {
            AnsiConsole.MarkupLine("[bold red]Could not find the Pokémon you were looking for![/]");
            return;
        }

        cli.DisplayPokemon(pokemon);
    }
}
