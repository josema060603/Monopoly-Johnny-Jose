namespace Monopoly;
public class Jail : ISpacing
{

    int ISpacing.Id { get ; set ; }=10;

    public bool CanGetOutOfJail((int, int )dice)
    {
        if(dice.Item1==dice.Item2)
        return true;
        return false;
    }
}