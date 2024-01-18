public interface ICommand
{
    public void Execute();
    public void Undo();
}

public class AddTextCommand : ICommand
{
    private TextEditor _editor;
    private string _textToAdd;
    private EditorMemento _backup;

    public AddTextCommand(TextEditor editor, string textToAdd)
    {
        _editor = editor;
        _textToAdd = textToAdd;
    }

    public void Execute()
    {
        _backup = _editor.Save();
        _editor.Content += _textToAdd;
    }

    public void Undo()
    {
        _editor.Restore(_backup);
    }
}

// Invoker(Command) and Caretaker(Memento)
public class CommandManager
{
    private Stack<ICommand> _commands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
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
}
