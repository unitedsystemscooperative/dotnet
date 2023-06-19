using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.ClientLib.Information.Models;

[ExcludeFromCodeCoverage]
public class ShipReviewData
{
    public string ShipId { get; set; } = "";
    public string Name { get; set; } = "";
    public string Manufacturer { get; set; } = "";
    public string ShipReview { get; set; } = "";
}