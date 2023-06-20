using UnitedSystemsCooperative.Web.Client.Pages;

namespace UnitedSystemsCooperative.Web.Client.Test.Pages;

public class HomeTests : TestContext
{
    [Fact]
    public void ShouldLoad()
    {
        RenderComponent<Home>();
    }
}