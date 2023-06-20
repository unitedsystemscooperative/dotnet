using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UnitedSystemsCooperative.Web.Shared.FormValidators;

public class FleetCarrierValidator : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var val = value?.ToString();
        ArgumentNullException.ThrowIfNull(val);
        Regex regex = new(@"^[A-Z0-9]{3}-[A-Z0-9]{3}$");

        return regex.IsMatch(val.ToUpper())
            ? ValidationResult.Success
            : new ValidationResult("This must be in ###-### format where # is a letter or number.",
                new[] {validationContext.MemberName ?? string.Empty});
    }
}