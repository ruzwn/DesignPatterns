namespace DesignPatterns.Command;

public class ConcreteCommand : Command
{
    private readonly Receiver _receiver;

    public ConcreteCommand(Receiver receiver)
    {
        _receiver = receiver;
    }

    public override void Execute()
    {
        _receiver.Action();
    }
}