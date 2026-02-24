namespace DesignPatterns.AbstractFactory;

public class Example
{
    public void Main()
    {
        Factory factory = new ConcreteFactory();
        ProductA productA = factory.CreateProductA();
        ProductB productB = factory.CreateProductB();
    }
}