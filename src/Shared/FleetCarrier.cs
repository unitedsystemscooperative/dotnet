using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using UnitedSystemsCooperative.Web.Shared.FormValidators;

namespace UnitedSystemsCooperative.Web.Shared;

[ExcludeFromCodeCoverage]
public class FleetCarrier : DbItem
{
    [Required] [FleetCarrierValidator] public override string Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string Owner { get; set; }

    public string OwnerId { get; set; }
    public string Purpose { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
}