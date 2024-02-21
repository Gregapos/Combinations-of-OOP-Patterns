using System.Runtime.CompilerServices;

public abstract class FileSystemNode
{
    public string Name { set; get; }

    protected FileSystemNode(string name)
    {
        Name = name;
    }
    public abstract void Execute();
}

public interface IIterableCollection
{
    public IIterator createDFIterator();
}

public class File : FileSystemNode
{
    public File(string name) : base(name) { }
    public override void Execute()
    {
        Console.WriteLine($"Opened File: {Name}");
    }
}

public class Folder : FileSystemNode, IIterableCollection
{
    public List<FileSystemNode> Children { get; } = new List<FileSystemNode>();

    public Folder(string name) : base(name) { }
    public override void Execute()
    {
        Console.WriteLine($"Opened Folder: {Name}");
        foreach (var node in Children)
        {
            node.Execute();
        }
    }

    public void Add(FileSystemNode node)
    {
        Children.Add(node);
    }

    public void Remove(FileSystemNode node)
    {
        Children.Remove(node);
    }

    public IIterator createDFIterator()
    {
        return new DepthFirstFileIterator(this);
    }
}
