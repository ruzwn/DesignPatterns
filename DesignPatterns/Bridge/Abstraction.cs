namespace DesignPatterns.Bridge;

public abstract class Abstraction
{
    protected Implementor _implementor;

    protected Abstraction(Implementor implementor)
    {
        _implementor = implementor;
    }

    public abstract void Operation();
}