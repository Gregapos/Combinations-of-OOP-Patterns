class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        CommandManager commandManager = new CommandManager();

        commandManager.ExecuteCommand(new AddTextCommand(editor, "First Addition|"));
        commandManager.ExecuteCommand(new AddTextCommand(editor, "Second Addition|"));

        Console.WriteLine("Content: " + editor.Content);

        commandManager.Undo();
        Console.WriteLine("After Undo: " + editor.Content);

        commandManager.Undo();
        Console.WriteLine("After Undo: " + editor.Content);
    }
}