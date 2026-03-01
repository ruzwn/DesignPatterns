namespace DesignPatterns.Command;

public class Example
{
    public void Main()
    {
        Invoker invoker = new Invoker(new ConcreteCommand(new Receiver()));
        invoker.Request();
    }
}