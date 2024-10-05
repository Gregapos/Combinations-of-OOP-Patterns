public class ControlCenter
{
    private static ControlCenter instance;
    private IStrategy _strategy;
    private ControlCenter() { }
    public static ControlCenter GetInstance()
    {
        if (instance == null)
        {
            instance = new ControlCenter();
        }
        return instance;
    }
    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    public void ReceiveAlert(string zoneName, string leafName)
    {
        Console.WriteLine($"DANGER! {leafName} detected something in {zoneName}");
        _strategy?.Alert();
    }
    public void ExecuteCommand(ICommand command) => command.Execute();
}