namespace Monopoly;
public class Jail : ISpacing
{

    public int Id { get ; }=11;

    public bool CanGetOutOfJail((int, int )dice)
    {
        if(dice.Item1==dice.Item2)
        return true;
        return false;
    }
}
public class GoToJail : ISpacing
{

    public int Id {get;}=31;
}