using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UnitedSystemsCooperative.Web.Shared;

[ExcludeFromCodeCoverage]
public class LoginModel
{
    public string? UserName { get; set; }

    [Required] [EmailAddress] public string? Email { get; set; }
}