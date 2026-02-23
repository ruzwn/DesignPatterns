namespace DesignPatterns.Strategy.Generic;

public class Context<TStrategy> where TStrategy : Strategy
{
    private readonly TStrategy _strategy;

    public Context(TStrategy strategy)
    {
        _strategy = strategy;
    }
}