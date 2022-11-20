namespace Monopoly;
public class Property1 : Property, ISpacing
{
    int ISpacing.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}