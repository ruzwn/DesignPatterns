namespace DesignPatterns.Decorator;

public class ConcreteBeforeDecorator : Decorator
{
    public ConcreteBeforeDecorator(Component component) : base(component)
    {
    }

    public override void Do()
    {
        DoBefore();
        base.Do();
    }

    private void DoBefore()
    {
    }
}