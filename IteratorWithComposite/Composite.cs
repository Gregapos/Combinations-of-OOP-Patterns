using System.Runtime.CompilerServices;

public abstract class IFileSystemItem
{
    protected string name;
    public abstract void Execute();
    public virtual void PushItemToStack(Stack<IFileSystemItem> stack) {return;}
}

public class File : IFileSystemItem
{
    public File(string name)
    {
        this.name = name;
    }

    public override void Execute()
    {
        Console.WriteLine($"Opened File: {name}");
    }
}

public class Directory : IFileSystemItem
{
    private List<IFileSystemItem> _items = new List<IFileSystemItem>();

    public Directory(string name)
    {
        this.name = name;
    }

    public override void Execute()
    {
        Console.WriteLine($"Opened Directory: {name}");
        foreach(var item in _items){
            item.Execute();
        }
    }

    public void Add(IFileSystemItem item)
    {
        _items.Add(item);
    }

    public void Remove(IFileSystemItem item)
    {
        _items.Remove(item);
    }

    public override void PushItemToStack(Stack<IFileSystemItem> stack) {
        for (int i = _items.Count - 1; i >= 0; i--)
        {
            stack.Push(_items[i]);
        }
    }
}
