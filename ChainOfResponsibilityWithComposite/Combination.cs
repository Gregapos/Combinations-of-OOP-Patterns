using System.ComponentModel;

public abstract class UIComponent
{
    protected string name;
    protected List<string> _handleableEvents = new List<string> { "Click" };
    public UIComponent Parent { get; set; }

    public UIComponent(string name)
    {
        this.name = name;
    }

    public virtual void HandleEvent(string uiEvent)
    {
        Parent.HandleEvent(uiEvent);
    }
}

public class Button : UIComponent
{
    public Button(string name) : base(name) { }

    public override void HandleEvent(string uiEvent)
    {
        if (uiEvent == "Click")
        {
            Console.WriteLine($"Event handled by {name}");
            Click();
        }
        else if (Parent != null)
            base.HandleEvent(uiEvent);

        else
            Console.WriteLine($"{name}: Event can't be handled.");
    }

    private void Click()
    {
        Console.WriteLine($"{name}: Clicked.");
    }
}

public class Panel : UIComponent
{
    private List<UIComponent> _children = new List<UIComponent>();

    public Panel(string name) : base(name)
    {
        _handleableEvents.AddRange(new string[] { "Scroll", "Close" });
    }

    public void AddComponent(UIComponent component)
    {
        _children.Add(component);
        component.Parent = this;
    }

    public override void HandleEvent(string uiEvent)
    {
        if (_handleableEvents.Contains(uiEvent))
        {
            Console.WriteLine($"Event handled by {name}");
            switch (uiEvent)
            {
                case "Click":
                    Click();
                    break;
                case "Scroll":
                    Scroll();
                    break;
                case "Close":
                    Close();
                    break;
            }
        }
        else if (Parent != null)
            base.HandleEvent(uiEvent);
        
        else
            Console.WriteLine($"{name}: Event can't be handled.");
    }

    private void Click()
    {
        Console.WriteLine($"{name}: Clicked.");
    }

    private void Scroll()
    {
        Console.WriteLine($"{name}: Scrolling.");
    }

    private void Close()
    {
        Console.WriteLine($"{name}: Closed.");
    }
}
