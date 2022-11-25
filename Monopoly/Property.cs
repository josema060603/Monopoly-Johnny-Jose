namespace Monopoly;

//Each property box will contain the property of Owner, price, number of green houses, number of red
//houses, and color of property.
public abstract class Property
{
    public string Name { get; set; }
    public string color { get; set; }
    public Player Owner
    {
        get; set;
    }
    public string Price
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
public class Property1 : Property, ISpacing
{
    public int Id { get ;  }=1;
}
public class Property2 : Property, ISpacing
{
   public  int Id { get ; }=2;
}
public class Property3 : Property, ISpacing
{
   public  int Id { get ; }=2;
}
public class Property4 : Property, ISpacing
{
   public  int Id { get ; }=4;
}
public class Property5 : Property, ISpacing
{
   public  int Id { get ; }=5;
}
public class Property6 : Property, ISpacing
{
   public  int Id { get ; }=6;
}
public class Property7 : Property, ISpacing
{
   public  int Id { get ; }=7;
}
public class Property8 : Property, ISpacing
{
   public  int Id { get ; }=8;
}
public class Property9 : Property, ISpacing
{
   public  int Id { get ; }=9;
}
public class Property10 : Property, ISpacing
{
   public  int Id { get ; }=10;
}
public class Property11 : Property, ISpacing
{
   public  int Id { get ; }=12;
}
public class Property12 : Property, ISpacing
{
   public  int Id { get ; }=13;
}
public class Property13 : Property, ISpacing
{
   public  int Id { get ; }=14;
}
public class Property14 : Property, ISpacing
{
   public  int Id { get ; }=15;
}
public class Property15 : Property, ISpacing
{
   public  int Id { get ; }=16;
}
public class Property16 : Property, ISpacing
{
   public  int Id { get ; }=17;
}
public class Property17 : Property, ISpacing
{
   public  int Id { get ; }=18;
}
public class Property18 : Property, ISpacing
{
   public  int Id { get ; }=19;
}
public class Property19 : Property, ISpacing
{
   public  int Id { get ; }=20;
}
public class Property20 : Property, ISpacing
{
   public  int Id { get ; }=22;
}
public class Property21 : Property, ISpacing
{
   public  int Id { get ; }=23;
}
