public interface ISecondInterface
{
    
}


public class SecondImplementation : ISecondInterface
{
    private IFirstInterface firstInterface;
    
    public SecondImplementation(IFirstInterface firstInterface)
    {
        
    }
    
    public override string ToString()
    {
        return $"Second_{GetHashCode()}";
    }
}