namespace DesignPatterns.Composite;

public class Composite : Component
{
    private readonly List<Component> _components = [];
    
    public override void Operation()
    {
    }

    public override void Add(Component child)
    {
        _components.Add(child);
    }

    public override void Remove(Component child)
    {
        _components.Remove(child);
    }

    public override Component GetChild(int index)
    {
        return _components[index];
    }
}