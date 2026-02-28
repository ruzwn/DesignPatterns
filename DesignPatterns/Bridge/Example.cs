namespace DesignPatterns.Bridge;

public class Example
{
    public void Main()
    {
        Abstraction abstraction = new ConcreteAbstraction(new ConcreteImplementor());
        abstraction.Operation();
    }
}