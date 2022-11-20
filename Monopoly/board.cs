namespace Monopoly;
public class Board
{
    public (int, ISpacing)[] GameBoard
    {
        get; set;
    }
    public Board()
    {
        GameBoard = new (int, ISpacing)[40];
    }
    public string GetBoardAsString()
    {
        string output = "";

        return output;
    }
    static public (int, int) RollDices(Player player)
    {
        int numberDice1 = 0;
        int numberDice2 = 0;
        return (numberDice1, numberDice2);
    }
}