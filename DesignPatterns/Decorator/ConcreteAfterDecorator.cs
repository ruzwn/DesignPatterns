namespace DesignPatterns.Decorator;

public class ConcreteAfterDecorator : Decorator
{
    public ConcreteAfterDecorator(Component component) : base(component)
    {
    }

    public override void Do()
    {
        base.Do();
        DoAfter();
    }

    private void DoAfter()
    {
    }
}