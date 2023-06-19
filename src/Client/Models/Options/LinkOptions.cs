using System.Diagnostics.CodeAnalysis;
using UnitedSystemsCooperative.Web.Client.Interfaces;

namespace UnitedSystemsCooperative.Web.Client.Models.Options;

[ExcludeFromCodeCoverage]
public class LinkOptions
{
    public const string SettingsName = "app-data:links";

    public NavItem[] NavItems { get; set; } = Array.Empty<NavItem>();
    public UscLink[] UscLinks { get; set; } = Array.Empty<UscLink>();
}

[ExcludeFromCodeCoverage]
public class NavItem
{
    public string To { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}

[ExcludeFromCodeCoverage]
public class UscLink : ILink
{
    public string Title { get; set; } = string.Empty;
    public string Replace { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
}