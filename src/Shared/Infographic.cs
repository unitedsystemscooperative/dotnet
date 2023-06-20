using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.Shared;

[ExcludeFromCodeCoverage]
public class Infographic
{
    public required string Id { get; set; }
    public required string Title { get; set; }
    public required string ImgPath { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}