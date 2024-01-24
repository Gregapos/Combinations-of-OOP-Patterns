public interface ICommand
{
    public void Execute();
}

public class LockCommand : ICommand
{
    private SecurityComponent component;

    public LockCommand(SecurityComponent component)
    {
        this.component = component;
    }

    public void Execute()
    {
        component.SetState(new LockedState(component));
    }
}

public class UnlockCommand : ICommand
{
    private SecurityComponent component;

    public UnlockCommand(SecurityComponent component)
    {
        this.component = component;
    }

    public void Execute()
    {
        component.SetState(new UnlockedState(component));
    }
}