using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.ClientLib.Information.Models;

[ExcludeFromCodeCoverage]
public class InfoButtonData
{
    public string Title { get; set; } = "";
    public string Caption { get; set; } = "";
    public bool IsLocal { get; set; }
    public string Link { get; set; } = "";
    public bool IsBeginner { get; set; }
}