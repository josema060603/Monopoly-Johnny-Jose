namespace Monopoly;
public class Player
{
    public string Name
    {
        get; set;
    }
    public int Money
    {
        get; set;
    }
    public IEnumerable<Property> Properties
    {
        get; set;
    }
    public Player(string name)
    {
        Name = name;
        Money = 1500;
    }
}
public static class ExtensionMethod
{
    static public bool HasPlayerLost(this Player player)
    {
        return false;
    }


}