using Microsoft.AspNetCore.Components;

namespace UnitedSystemsCooperative.Web.ClientLib.Shared.Test;

public class IndentedDivTests : TestContext
{
    [Fact]
    public void IndentedDivShowsChildContent()
    {
        var cut = RenderComponent<IndentedDiv>(parameters =>
            parameters.AddChildContent("<p>show this as a child</p>"));
        
        cut.MarkupMatches("<div class=\"ml-4\"><p>show this as a child</p></div>");
    }
}