public abstract class State
{
    protected SecurityComponent component;
    public State(SecurityComponent component) => this.component = component;
    public abstract void Detect(string leafName);
}

public class LockedState : State
{
    public LockedState(SecurityComponent component) : base(component) { }
    public override void Detect(string leafName) => component.Alert(leafName);
}

public class UnlockedState : State
{
    public UnlockedState(SecurityComponent component) : base(component) { }
    public override void Detect(string leafName) => component.Log(leafName);
}