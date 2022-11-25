namespace Monopoly;
public class Board
{
    public (ISpacing, int)[] GameBoard
    {
        get; set;
    }
    public Board()
    {
        GameBoard = new (ISpacing, int)[40];
        var parkingLot=new FreeParkingLot();
        var jail=new Jail();
        GameBoard[20]= (parkingLot, parkingLot.Id);
        GameBoard[10]=(jail, jail.Id);
    }
    public string GetBoardAsString()
    {
        string output = "";

        return output;
    }
    static public (int, int) RollDices(Player player)
    {
        int numberDice1 = new Random().Next(1, 7);
        int numberDice2 = new Random().Next(1, 7);
        return (numberDice1, numberDice2);
    }
}