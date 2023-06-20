using Microsoft.Extensions.Options;
using UnitedSystemsCooperative.Web.Client.Models.Options;
using UnitedSystemsCooperative.Web.Client.Pages.About;

namespace UnitedSystemsCooperative.Web.Client.Test.Pages.About;

public class RulesTests : TestContext
{
    [Fact]
    public void ShouldLoad()
    {
        UscRules rules = new()
        {
            Discord = new[] {"d rule1", "d rule2", "d rule3"},
            Member = new[] {"m rule1", "m rule2", "m rule3"}
        };
        AboutOptions about = new()
        {
            Rules = rules
        };
        var options = Options.Create(about);
        Services.AddSingleton(options);

        var cut = RenderComponent<Rules>();

        var discordRulesEl = cut.FindAll("[data-ruleset=\"discord\"]");
        var memberRulesEl = cut.FindAll("[data-ruleset=\"member\"]");
        
        Assert.Equal(3, discordRulesEl.Count);
        Assert.Equal(3, memberRulesEl.Count);
    }
}