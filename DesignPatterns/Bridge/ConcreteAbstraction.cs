namespace DesignPatterns.Bridge;

public class ConcreteAbstraction : Abstraction
{
    public ConcreteAbstraction(Implementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        _implementor.OperationImpl();
    }
}