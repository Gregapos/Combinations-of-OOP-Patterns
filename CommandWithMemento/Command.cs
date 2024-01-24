public interface ICommand
{
    public void Execute();
    public void Undo();
}

public class AddTextCommand : ICommand
{
    private TextService _service;
    private string _newText;
    private Memento _backup;

    public AddTextCommand(TextService service, string newText)
    {
        _service = service;
        _newText = newText;
    }

    public void Execute()
    {
        _backup = _service.Save();
        _service.Content += _newText;
    }

    public void Undo()
    {
        _service.Restore(_backup);
    }
}

// Invoker(Command) and Caretaker(Memento)
public class CommandInvoker
{
    private Stack<ICommand> _commands = new Stack<ICommand>();

    public void Execute(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count > 0)
        {
            var command = _commands.Pop();
            command.Undo();
        }
    }

    public bool IsEmpty()
    {
        return _commands.Count == 0;
    }
}
