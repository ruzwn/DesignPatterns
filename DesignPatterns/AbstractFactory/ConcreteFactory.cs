namespace DesignPatterns.AbstractFactory;

public class ConcreteFactory : Factory
{
    public override ProductA CreateProductA()
    {
        return new ConcreteProductA();
    }

    public override ProductB CreateProductB()
    {
        return new ConcreteProductB();
    }
}