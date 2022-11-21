namespace Monopoly;
public struct Player
{
    public string Name
    {
        get; set;
    }
    public int Money
    {
        get; set;
    }
    public int moneyToPay
    {
        get; set;
    }=0;
    public IEnumerable<Property> Properties
    {
        get; set;
    }
    public Player(string name)
    {
        Name = name;
        Money = 1500;
        Properties = new List<Property>  ();
    }
}
public static class ExtensionMethod
{
    static public bool HasPlayerLost(this Player player)
    {
        if(player.moneyToPay>player.Money)
        return true;
        return false;
    }


}