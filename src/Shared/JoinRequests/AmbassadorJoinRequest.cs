using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.Shared.JoinRequests;

[ExcludeFromCodeCoverage]
public class AmbassadorJoinRequest : JoinRequestBase
{
    [Required]
    public string? Group { get; set; }

    public bool NeedPrivate { get; set; } = false;
    
}