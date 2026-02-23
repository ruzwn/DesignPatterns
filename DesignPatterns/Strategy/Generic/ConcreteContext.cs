namespace DesignPatterns.Strategy.Generic;

public class ConcreteContext<TStrategy> : Context where TStrategy : Strategy
{
    private object _data;

    private readonly TStrategy _strategy;

    public ConcreteContext(object data, TStrategy strategy)
    {
        _data = data;

        _strategy = strategy;
    }

    public override void Do()
    {
        _strategy.Do(_data);
    }
}