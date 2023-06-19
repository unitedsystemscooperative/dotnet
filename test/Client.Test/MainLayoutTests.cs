using Microsoft.Extensions.Options;
using MudBlazor;
using UnitedSystemsCooperative.Web.Client.Models.Options;
using UnitedSystemsCooperative.Web.Client.Shared;

namespace UnitedSystemsCooperative.Web.Client.Test;

public class MainLayoutTests : TestContext
{
    [Fact]
    public void Loads()
    {
        var linkOptions = new LinkOptions()
        {
            NavItems = new[]
            {
                new NavItem() {Text = "ShowText", To = "ToText"},
                new NavItem() {Text="ShowText2", To = "ToText2"}
            }
        };
        var options = Options.Create(linkOptions);
        Services.AddSingleton(options);

        ComponentFactories.AddStub<MudThemeProvider>();
        ComponentFactories.AddStub<MudDialogProvider>();
        ComponentFactories.AddStub<MudSnackbarProvider>();

        var cut = RenderComponent<MainLayout>();

        var navLinks = cut.FindAll(".full-nav-link");
        Assert.Equal(2, navLinks.Count);
        
    }
}