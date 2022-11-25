namespace Monopoly;

//Each property box will contain the property of Owner, price, number of green houses, number of red
//houses, and color of property.
public abstract class Property:ISpacing
{
    protected Property(string[] characs)
    {
      Name=characs[0];
      Price=int.Parse(characs[1]);
      Rent=int.Parse(characs[2]);
      GreenHouseRentIncrement=int.Parse(characs[3]);
      HotelRentIncrement=int.Parse(characs[4]);
    }

    public string Name { get; set; }
    public Player Owner
    {
        get; set;
    }
    public int Price
    {
        get; 
    }
    public int GreenHouses
    {
        get; set;
    }
    public int Hotel
    {
        get; set;
    }
    protected int Rent
    {
        get; set;
    }
    public int GreenHouseRentIncrement
    {
        get; 
    }
    public int HotelRentIncrement
    {
        get; 
    }
    public int Id { get; }

    public void ChangeOfOwner(Player newOwner, int price)
    {

    }
    public void AddGreenHouse()
    {
      
            GreenHouses++;
            Rent+=GreenHouseRentIncrement;
    

    }
    public void AddHotel()
    {
        if (this.GreenHouses > 4)
        {
            GreenHouses++;
        }

    }
    static public void ChangePosition(Board board)
    {

    }


}
