using System.Runtime.CompilerServices;

public abstract class IFileSystemItem
{
    public string Name { set; get; }
    public abstract void Execute();
}

public interface IIterableCollection
{
    public IIterator createDFIterator();
}

public class File : IFileSystemItem
{
    public File(string name)
    {
        Name = name;
    }

    public override void Execute()
    {
        Console.WriteLine($"Opened File: {Name}");
    }
}

public class Directory : IFileSystemItem, IIterableCollection
{
    private List<IFileSystemItem> items = new List<IFileSystemItem>();

    public Directory(string name)
    {
        Name = name;
    }

    public override void Execute()
    {
        Console.WriteLine($"Opened Directory: {Name}");
        foreach (var item in items)
        {
            item.Execute();
        }
    }

    public void Add(IFileSystemItem item)
    {
        items.Add(item);
    }

    public void Remove(IFileSystemItem item)
    {
        items.Remove(item);
    }

    public List<IFileSystemItem> GetItems()
    {
        return items;
    }

    public IIterator createDFIterator()
    {
        return new DepthFirstFileIterator(this);
    }
}
