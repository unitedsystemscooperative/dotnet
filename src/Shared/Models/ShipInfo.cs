namespace UnitedSystemsCooperative.Web.Shared.Models;

public class ShipInfo
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public ShipSize Size { get; set; }
    public string? Requires { get; set; }
    public string ShipImg { get; set; } = "";
}

public enum ShipSize
{
    S = 1,
    M = 2,
    L = 3
}