namespace DesignPatterns.Strategy;

public class ConcreteContext : Context
{
    private object _data;

    private readonly Strategy _strategy;

    public ConcreteContext(object data, Strategy strategy)
    {
        _data = data;

        _strategy = strategy;
    }

    public override void Do()
    {
        _strategy.Do(_data);
    }
}