using System.Diagnostics.CodeAnalysis;

#pragma warning disable CS8618

namespace UnitedSystemsCooperative.Bot.Models;

[ExcludeFromCodeCoverage]
public class Rank
{
    public string Name { get; set; }
    public string? InaraName { get; set; }
    public IEnumerable<string> Ranks { get; set; }
}
