using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using UnitedSystemsCooperative.Web.Client.Interfaces;
using UnitedSystemsCooperative.Web.Client.Pages.About;
using UnitedSystemsCooperative.Web.Shared;

namespace UnitedSystemsCooperative.Web.Client.Test.Pages.About;

public class AlliesTests : TestContext
{
    [Fact]
    public void ShouldShowLoading()
    {
        var task = new TaskCompletionSource<IEnumerable<Ally>>();
        var mock = new Mock<IItemService<Ally>>();
        mock
            .Setup(x => x.GetFromStore())
            .Returns(() => null);
        mock
            .Setup(x => x.GetFromServer())
            .Returns(task.Task);
        Services.AddSingleton(mock.Object);

        var cut = RenderComponent<Allies>();

        var loadingEl = cut.Find("#allies-loading");
        Assert.NotNull(loadingEl);
        loadingEl.MarkupMatches("<div id=\"allies-loading\">Loading allies</div>");
    }

    [Fact]
    public void ShouldShowNoAlliesFound()
    {
        var mock = SetupItemServiceMock(null, Array.Empty<Ally>());
        Services.AddSingleton(mock.Object);

        var cut = RenderComponent<Allies>();

        var noAlliesEl = cut.Find("#allies-none");
        Assert.NotNull(noAlliesEl);
        noAlliesEl.MarkupMatches("<div id=\"allies-none\">No allies found</div>");
    }

    [Fact]
    public void ShouldShowAllies()
    {
        var mock = SetupItemServiceMock(null,
            new[]
            {
                new Ally() {Id = "1", Name = "First"},
                new Ally() {Id = "2", Name = "Second"}
            });
        Services.AddSingleton(mock.Object);

        var cut = RenderComponent<Allies>();

        var alliesEls = cut.FindAll(".mud-typography-body1");
        Assert.Equal(2, alliesEls.Count);
    }

    [Fact]
    public void ShouldShowError()
    {
        var task = new TaskCompletionSource<IEnumerable<Ally>>();
        task.SetCanceled();
        var mock = new Mock<IItemService<Ally>>();
        mock
            .Setup(x => x.GetFromStore())
            .Returns(() => null);
        mock
            .Setup(x => x.GetFromServer())
            .Returns(task.Task);
        Services.AddSingleton(mock.Object);

        var cut = RenderComponent<Allies>();

        var errorEl = cut.Find("#allies-error");
        Assert.NotNull(errorEl);
        errorEl.MarkupMatches("<div id=\"allies-error\">Error accessing Allies.</div>");
    }

    private Mock<IItemService<Ally>> SetupItemServiceMock(IEnumerable<Ally>? storeReturnValue,
        IEnumerable<Ally> serverReturnValue)
    {
        var mock = new Mock<IItemService<Ally>>();
        mock
            .Setup(x => x.GetFromStore())
            .Returns(storeReturnValue);
        mock
            .Setup(x => x.GetFromServer())
            .ReturnsAsync(serverReturnValue);

        return mock;
    }
}