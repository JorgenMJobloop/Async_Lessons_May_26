using Spectre.Console;
public sealed class CLI
{
    public void DisplayMemes(IEnumerable<Meme> memes)
    {
        var table = new Table()
        .Title("Meme images from ImgFlip")
        .AddColumn("Id")
        .AddColumn("Name")
        .AddColumn("Size")
        .AddColumn("Boxes");

        foreach (var meme in memes.Take(10))
        {
            table.AddRow(
                meme.Id!,
                meme.Name!,
                $"{meme.Width}x{meme.Height}",
                meme.BoxCount.ToString()
            );
        }

        AnsiConsole.Write(table);
    }

    public void DisplayPokemon(Pokemon pokemon)
    {
        var panel = new Panel($"""
        [bold]Name:[/] {pokemon.Name}
        [bold]Id:[/] {pokemon.Id}
        [bold]Height:[/] {pokemon.Height}
        [bold]Weight:[/] {pokemon.Weight}
        [bold]Types:[/] {string.Join(", ", pokemon.Types.Select(t => t.Type.Name))}
        [bold]Abilities:[/] {string.Join(", ", pokemon.Abilities.Select(a => a.Ability.Name))}
        """)
        {
            Header = new PanelHeader("Pokémon")
        };

        AnsiConsole.Write(panel);

        var statTable = new Table()
        .Title("Stats")
        .AddColumn("Stat")
        .AddColumn("Value");

        foreach (var stat in pokemon.Stats)
        {
            statTable.AddRow(stat.Stat.Name, stat.BaseStat.ToString());
        }

        AnsiConsole.Write(statTable);
    }
}