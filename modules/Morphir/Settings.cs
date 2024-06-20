using System.ComponentModel;
using Spectre.Console.Cli;

namespace Morphir;

public class MakeSettings:CommandSettings
{
    [CommandOption("-p|--project-dir")]
    [DefaultValue(".")]
    public string ProjectDir { get; set; } = ".";
    [CommandOption("-o|--output")]
    [DefaultValue("morphir-ir.json")]
    public string Output { get; set; } = "morphir-ir.json";
    [CommandOption("-i|--indent")]
    [DefaultValue(false)]
    public bool IndentJson { get; set; }
}

[Description("Fetch dependencies")]
public class DependencyFetchSettings:CommandSettings
{
    [CommandOption("-p|--project-dir")]
    [DefaultValue(".")]
    public string ProjectDir { get; set; } = ".";
}

public class ConsoleSettings:CommandSettings
{
}