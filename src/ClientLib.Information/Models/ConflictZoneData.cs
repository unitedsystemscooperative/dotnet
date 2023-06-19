using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.ClientLib.Information.Models;

[ExcludeFromCodeCoverage]
public class ConflictZoneData
{
    public string ConflictZoneLevel { get; init; } = "";
    public int NumberCompleted { get; init; }
}