namespace Monopoly;

//Each property box will contain the property of Owner, price, number of green houses, number of red
//houses, and color of property.
public abstract class Property
{
    public string Name{get; set;}
    public string color { get; set; }
    public string Owner
    {
        get; set;
    }
    public string Price
    {
        get; set;
    }
    public int GreenHouses
    {
        get; set;
    }
    public int RedHouses
    {
        get; set;
    }


    public void ChangeOfOwner(Player newOwner)
    {

    }
    public void AddGreenHouse()
    {

    }
    public void AddRedHouse()
    {

    }
    static public void ChangePosition(Board board)
    {

    }


}
