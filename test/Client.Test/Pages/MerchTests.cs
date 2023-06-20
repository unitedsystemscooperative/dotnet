using Moq;
using UnitedSystemsCooperative.Web.Client.Interfaces;
using UnitedSystemsCooperative.Web.Client.Pages;
using UnitedSystemsCooperative.Web.Client.Services;

namespace UnitedSystemsCooperative.Web.Client.Test.Pages;

public class MerchTests : TestContext
{
    [Fact]
    public void ShouldLoad()
    {
        var mockUrlService = new Mock<IUrlService>();
        mockUrlService
            .Setup(x => x.GetUscLinkByKey(It.IsAny<string>()))
            .Returns("https://localhost/merchurl");
        Services.AddSingleton(mockUrlService.Object);

        var cut = RenderComponent<Merch>();

        var links = cut.FindAll("a");
        
        foreach(var link in links)
        {
            var href = link.Attributes.GetNamedItem("href")?.Value;
            Assert.NotNull(href);
            Assert.Equal("https://localhost/merchurl", href);
        }
    }
}