namespace UnitedSystemsCooperative.Web.Client.Interfaces;

public interface IUrlService
{
    /// <summary>
    /// Replaces any bracketed usc keys in a link field
    ///
    /// example: `{discord}`
    /// </summary>
    /// <param name="linkItems">Items to review and replace</param>
    /// <typeparam name="T">Must have a Link field to satisfy ILink</typeparam>
    /// <returns></returns>
    public IEnumerable<T> ReplaceUscUrls<T>(IEnumerable<T> linkItems) where T : ILink;

    public string GetUscLinkByKey(string key);
}