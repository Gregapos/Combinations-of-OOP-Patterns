using System.Net.Mail;

public abstract class SecurityComponent
{
    public string Name { get; private set; }
    protected State _state;
    public SecurityComponent(string name)
    {
        Name = name;
    }
    public virtual void SetState(State state) => _state = state;
    public virtual void Detect() => _state.Detect(Name);
    public virtual void Alert(string leafName) => ControlCenter.GetInstance().ReceiveAlert(Name, leafName);
    public virtual void Log(string leafName) => Console.WriteLine($"{Name}: Detection from {leafName}");
}

public class Camera : SecurityComponent
{
    public Camera(string name) : base(name) { }
}

public class MotionSensor : SecurityComponent
{
    public MotionSensor(string name) : base(name) { }

}

public class SecurityComponentZone : SecurityComponent
{
    private List<SecurityComponent> _children = new List<SecurityComponent>();

    public SecurityComponentZone(string name) : base(name) { }

    public SecurityComponentZone AddChild(SecurityComponent child)
    {
        _children.Add(child);
        return this;
    }

    public void RemoveChild(SecurityComponent child)
    {
        _children.Remove(child);
    }

    public override void SetState(State state)
    {
        _state = state;
        foreach (var component in _children)
        {
            component.SetState(state);
        }
    }
}
