namespace DesignPatterns.Decorator;

public abstract class Decorator : Component
{
    private readonly Component _component;

    protected Decorator(Component component)
    {
        _component = component;
    }

    public override void Do()
    {
        _component.Do();
    }
}