namespace DesignPatterns.Composite;

public abstract class Component
{
    public abstract void Operation();

    public virtual void Add(Component child)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component child)
    {
        throw new NotImplementedException();
    }

    public virtual Component GetChild(int index)
    {
        throw new NotImplementedException();
    }
}