using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Bot.Models;

// Disable nullable warning.
#pragma warning disable CS8618
[ExcludeFromCodeCoverage]
public class InaraConfig
{
    public const string ConfigName = "InaraConfig";
    public string Token { get; set; }
    public string ApiUrl { get; set; }
}
