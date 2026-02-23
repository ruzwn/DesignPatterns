namespace DesignPatterns.Strategy;

public abstract class Context
{
    private readonly Strategy _strategy;

    protected Context(Strategy strategy)
    {
        _strategy = strategy;
    }

    public void Do()
    {
        _strategy.Do();
    }
}