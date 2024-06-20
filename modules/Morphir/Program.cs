using Morphir;
using Spectre.Console;
using Spectre.Console.Cli;

public static class Program
{
    public static int Main(string[] args)
    {
        var app = new CommandApp();
        app.Configure(config =>
        {
            config.AddBranch("dependency", dep =>
            {
                dep.AddCommand<DependencyFetchCommand>("fetch");
            });
            config.AddCommand<MakeCommand>("make").WithDescription("Generate IR from source files");
            config.AddCommand<ConsoleCommand>("console").WithDescription("Start the Morphir console");
        });
        return app.Run(args);
    }
}