using System.ComponentModel.DataAnnotations;
using UnitedSystemsCooperative.Web.Shared.FormValidators;

namespace UnitedSystemsCooperative.Web.Shared.Test;

public class FleetCarrierValidatorTests
{
    [Theory]
    [InlineData("AAA-BBB")]
    [InlineData("A5A-6BB")]
    [InlineData("ASA-554")]
    [InlineData("123-ABC")]
    public void ShouldReturnSuccess(string id)
    {
        var testForm = new TestFleetCarrierForm() {Id = id};
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(testForm.Id,
            new ValidationContext(testForm){MemberName = "Id"},
                results);
        
        Assert.True(result);
        Assert.Empty(results);
    }

    [Theory]
    [InlineData("/12-123")]
    [InlineData("123ABC")]
    [InlineData("")]
    public void ShouldReturnFail(string id)
    {
        var testForm = new TestFleetCarrierForm()
        {
            Id = id
        };
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(testForm.Id,
            new ValidationContext(testForm) {MemberName = "Id"},
            results);
        
        Assert.False(result);
        Assert.Single(results);
        Assert.Equal("This must be in ###-### format where # is a letter or number.", results[0].ErrorMessage);
        Assert.Equal("Id", results[0].MemberNames.First());
    }
}

internal class TestFleetCarrierForm
{
    [FleetCarrierValidator] public string Id { get; init; } = "";
}