namespace UnitedSystemsCooperative.Web.ClientLib.Shared.Test;

public class PaperPTests : TestContext
{
    [Fact]
    public void ShouldDisplayDefault1()
    {
        var cut = RenderComponent<PaperP>();
        
        cut.MarkupMatches("<div class=\"mud-paper mud-elevation-1 pa-1\" style:ignore=\"\"></div>");
    }

    [Fact]
    public void ShouldDisplayPassedValue()
    {
        var cut = RenderComponent<PaperP>(parameters =>
            parameters.Add(p => p.Padding, 5));
        
        cut.MarkupMatches("<div class=\"mud-paper mud-elevation-1 pa-5\" style:ignore=\"\"></div>");
    }

    [Fact]
    public void ShouldShowChildContent()
    {
        var cut = RenderComponent<PaperP>(parameters =>
            parameters.AddChildContent("<p>show this as a child</p>"));
        
        cut.MarkupMatches("<div class=\"mud-paper mud-elevation-1 pa-1\" style:ignore><p>show this as a child</p></div>");
    }
}