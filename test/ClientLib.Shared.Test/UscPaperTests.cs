namespace UnitedSystemsCooperative.Web.ClientLib.Shared.Test;

public class UscPaperTests : TestContext
{
    [Fact]
    public void ShouldShowChildContent()
    {
        var cut = RenderComponent<UscPaper>(parameters =>
            parameters.AddChildContent("<p>show this as a child</p>"));
        
        cut.MarkupMatches("<div class=\"mud-paper mud-paper-outlined\" style=\"border-color: var(--mud-palette-primary);\"><p>show this as a child</p></div>");
    }
}