namespace DesignPatterns.FactoryMethod;

public class ConcreteApplication : Application
{
    public override Product CreateProduct()
    {
        return new ConcreteProduct();
    }
}