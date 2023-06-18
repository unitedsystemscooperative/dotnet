namespace UnitedSystemsCooperative.Web.ClientLib.Information.Models;

public class MiningMapData
{
    public string System { get; set; } = "";
    public string Body { get; set; } = "";
    public string Material { get; set; } = "";
    public int MaterialInara { get; set; }
    public string MiningType { get; set; } = "";
    public string? Overlap { get; set; }
    public string Link { get; set; } = "";
}