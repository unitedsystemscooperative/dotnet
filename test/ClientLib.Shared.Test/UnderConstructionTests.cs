namespace UnitedSystemsCooperative.Web.ClientLib.Shared.Test;

public class UnderConstructionTests : TestContext
{
    [Fact]
    public void ShouldDisplayTitle()
    {
        var cut = RenderComponent<UnderConstruction>(parameters =>
            parameters.Add(p => p.Title, "Test Title"));

        var h2 = cut.Find("h2");
        h2.MarkupMatches("<h2 class=\"mud-typography mud-typography-h2\">Test Title</h2>");
    }

    [Fact]
    public void ShouldNotDisplayTitle()
    {
        var cut = RenderComponent<UnderConstruction>();
        Assert.Throws<ElementNotFoundException>(() => cut.Find("h2"));
    }
}