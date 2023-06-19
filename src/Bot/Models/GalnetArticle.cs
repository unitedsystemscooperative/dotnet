using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Bot.Models;

#pragma warning disable CS8618
[ExcludeFromCodeCoverage]
public class GalnetArticle
{
    public string Title { get; set; }
    public string Date { get; set; }
    public string Content { get; set; }
}
