using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.Shared;

[ExcludeFromCodeCoverage]
public class FactionSystem : DbItem
{
    [Required] public required string Name { get; set; }
    public bool IsControlled { get; set; } = false;
}