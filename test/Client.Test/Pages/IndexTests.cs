

using UnitedSystemsCooperative.Web.Client.Pages;

namespace UnitedSystemsCooperative.Web.Client.Test.Pages;

public class IndexTests : TestContext
{
    [Fact]
    public void IndexRedirectsToHome()
    {
        var nav = Services.GetRequiredService<FakeNavigationManager>();
        RenderComponent<Index>();
        
        Assert.Equal("http://localhost/home", nav.Uri);
    }
}