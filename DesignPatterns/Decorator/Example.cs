namespace DesignPatterns.Decorator;

public class Example
{
    public void Main()
    {
        Component decorator =
            new ConcreteAfterDecorator(
                new ConcreteBeforeDecorator(
                    new ConcreteComponent()));
    }
}