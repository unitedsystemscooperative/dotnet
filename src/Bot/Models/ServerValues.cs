using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Bot.Models;

[ExcludeFromCodeCoverage]
public class ServerValues
{
    public const string ConfigName = "ServerValues";
    public string GalNetChannelKey { get; set; }
    public string GalNetTitlesKey { get; set; }
    public ulong JoinChannelId { get; set; }
}