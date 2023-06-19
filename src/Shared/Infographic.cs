using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.Shared;

[ExcludeFromCodeCoverage]
public class Infographic
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string ImgPath { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}