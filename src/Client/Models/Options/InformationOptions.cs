using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.Client.Models.Options;

[ExcludeFromCodeCoverage]
public class InformationOptions
{
    public const string SettingsName = "app-data:information";

    public Infographic[] Infographics = Array.Empty<Infographic>();
}

[ExcludeFromCodeCoverage]
public class Infographic
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public int Width { get; set; }
    public int Height { get; set; }
}