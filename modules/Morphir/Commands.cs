using System.ComponentModel;

namespace Morphir;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;
using Spectre.Console;


internal sealed class MakeCommand:Command<MakeSettings>
{
    public override int Execute([NotNull]CommandContext context, MakeSettings settings)
    {
        AnsiConsole.MarkupLine("Running [green]make[/] command");
        AnsiConsole.MarkupLine($"settings: {settings}");
        return 0;
    }
}

internal sealed class DependencyFetchCommand:Command<DependencyFetchSettings>
{
    public override int Execute([NotNull]CommandContext context, DependencyFetchSettings settings)
    {
        AnsiConsole.MarkupLine("Running [green]dependency fetch[/] command");
        AnsiConsole.MarkupLine($"settings: {settings}");
        return 0;
    }
}