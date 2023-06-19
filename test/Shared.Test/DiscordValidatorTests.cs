using System.ComponentModel.DataAnnotations;
using UnitedSystemsCooperative.Web.Shared.FormValidators;

namespace UnitedSystemsCooperative.Web.Shared.Test;

public class DiscordValidatorTests
{
    [Fact]
    public void ShouldReturnSuccess()
    {
        var testForm = new TestDiscordForm
        {
            DiscordName = "name#1234"
        };
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(testForm.DiscordName,
            new ValidationContext(testForm){MemberName = "DiscordName"},
            results);

        Assert.True(result);
    }

    [Theory]
    [InlineData("name")]
    [InlineData("")]
    public void ShouldReturnFailed(string name)
    {
        var testForm = new TestDiscordForm()
        {
            DiscordName = name
        };
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(testForm.DiscordName,
            new ValidationContext(testForm) {MemberName = "DiscordName"},
            results);
        
        Assert.False(result);
        Assert.Single(results);
        Assert.Equal("This must be in {username}#0000 format", results[0].ErrorMessage);
        Assert.Equal("DiscordName",results[0].MemberNames.First());
    }
}

internal class TestDiscordForm
{
    [DiscordValidator] public string DiscordName { get; init; } = "";
}