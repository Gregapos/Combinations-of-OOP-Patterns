public abstract class FileSystemNode
{
    public string Name { get; set; }

    protected FileSystemNode(string name)
    {
        Name = name;
    }

    public abstract long GetSize();
}

public class File : FileSystemNode
{
    public long Size { get; }
    public File(string name, long Size) : base(name) 
    {
        this.Size = Size;
    }

    public override long GetSize()
    {
        return Size;
    }
    
}

public class Folder : FileSystemNode
{
    public List<FileSystemNode> Children {get;} = new List<FileSystemNode>();

    public Folder(string name) : base(name) { }

    public void AddChild(FileSystemNode child)
    {
        Children.Add(child);
    }

    public void RemoveChild(FileSystemNode child)
    {
        Children.Remove(child);
    }

    public override long GetSize()
    {
        return Children.Sum(x => x.GetSize());
    }

}
