using System.Diagnostics.CodeAnalysis;
using UnitedSystemsCooperative.Web.Client.Modules.About;

namespace UnitedSystemsCooperative.Web.Client.Models.Options;

[ExcludeFromCodeCoverage]
public class AboutOptions
{
    public const string SettingsName = "app-data:about";

    public UscRules? Rules { get; set; }
    public AboutLayoutButtonInfo[]? LayoutButtonInfos { get; set; } = Array.Empty<AboutLayoutButtonInfo>();
}

[ExcludeFromCodeCoverage]
// ReSharper disable once ClassNeverInstantiated.Global
public class UscRules
{
    public string[] Discord { get; set; } = Array.Empty<string>();
    public string[] Member { get; set; } = Array.Empty<string>();
}