public class ControlCenter
{
    private static ControlCenter instance;
    private Strategy _strategy;
    public static ControlCenter GetInstance()
    {
        if (instance == null)
        {
            instance = new ControlCenter();
        }
        return instance;
    }

    public void setStrategy(Strategy strategy) => _strategy = strategy;
    public void ReceiveAlert(string zoneName, string leafName)
    {
        Console.WriteLine($"DANGER! {leafName} detected something in {zoneName}");
        _strategy?.Alert();
    }
    public void ExecuteCommand(ICommand command) => command.Execute();
}