using System.Diagnostics.CodeAnalysis;
using Spectre.Console;
using Spectre.Console.Cli;
using Microsoft.ClearScript.V8;

namespace Morphir;

internal sealed class ConsoleCommand:Command<ConsoleSettings>
{
    public override int Execute([NotNull]CommandContext context, ConsoleSettings settings)
    {
        AnsiConsole.MarkupLine("Running [green]console[/] command");
        AnsiConsole.MarkupLine($"settings: {settings}");
        var engine = new V8ScriptEngine();
        engine.AddHostType("Console", typeof(Console));
        engine.ExecuteCommand("""
                              Console.WriteLine('Hello, World!');
                              """);
        return 0;
    }
}