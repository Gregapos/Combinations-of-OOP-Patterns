public interface ICommand
{
    public void Execute();
}

public abstract class BaseCommand : ICommand
{
    protected SecurityComponent component;
    public virtual void Execute() { }
}

public class LockCommand : BaseCommand
{
    public LockCommand(SecurityComponent component)
    {
        this.component = component;
    }

    public override void Execute()
    {
        component.SetState(new LockedState(component));
    }
}

public class UnlockCommand : BaseCommand
{
    public UnlockCommand(SecurityComponent component)
    {
        this.component = component;
    }

    public override void Execute()
    {
        component.SetState(new UnlockedState(component));
    }
}