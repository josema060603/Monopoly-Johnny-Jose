namespace Monopoly;

//Each property box will contain the property of Owner, price, number of green houses, number of red
//houses, and color of property.
public class Board
{
    public string Owner {
        get; set; 
    }
    public string price{
        get; set;
    }
    public int GreenHouses{
        get; set;
    }
    public int RedHouses{
        get; set;
    }
    public string Color{
        get;
    }
    static void ChangeOfOwner(Board Property, Player player){
        Property.owner = player.Name;
        player.Money - Property.price;
    }
}
