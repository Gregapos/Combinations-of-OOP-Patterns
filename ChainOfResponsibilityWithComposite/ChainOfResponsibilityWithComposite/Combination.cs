using System.ComponentModel;

public interface IUIComponent
{
    public IUIComponent Parent {get; set;}

    public void HandleEvent(string uiEvent);
}

public class Button : IUIComponent
{
    private string name;
    public IUIComponent Parent {get; set;}
    private List<string> _handableEvents = new List<string>{"Click"};

    public Button(string name)
    {
        this.name = name;
    }

    public void HandleEvent(string uiEvent)
    {
        if (_handableEvents.Contains(uiEvent))
        {
            Console.WriteLine($"Event handled by {name}");
            return;
        }
        else if (Parent != null)
        {
            Parent.HandleEvent(uiEvent);
            return;
        }
        
        Console.WriteLine($"{name}: Event can't be handled.");
    }
}

public class Panel : IUIComponent
{
    private string name;
    public IUIComponent Parent {get; set;}
    private List<string> _handableEvents = new List<string>{"Scroll", "Close"};
    private List<IUIComponent> _children = new List<IUIComponent>();

    public Panel(string name)
    {
        this.name = name;
    }

    public void AddComponent(IUIComponent component)
    {
        _children.Add(component);
        component.Parent = this;
    }

    public void HandleEvent(string uiEvent)
    {
        if (_handableEvents.Contains(uiEvent))
        {
            Console.WriteLine($"Event handled by {name}");
            return;
        }
        else if (Parent != null)
        {
            Parent.HandleEvent(uiEvent);
            return;
        }
        
        Console.WriteLine($"{name}: Event can't be handled.");
    }
}
