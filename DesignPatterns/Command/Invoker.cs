namespace DesignPatterns.Command;

public class Invoker
{
    private readonly Command _command;

    public Invoker(Command command)
    {
        _command = command;
    }

    public void Request()
    {
        _command.Execute();
    }
}