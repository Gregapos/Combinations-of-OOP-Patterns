public interface IIterator
{
    bool HasMore();
    FileSystemNode GetNext();
}

public class DepthFirstFileIterator : IIterator
{
    private Stack<FileSystemNode> stack = new Stack<FileSystemNode>();

    public DepthFirstFileIterator(Folder root)
    {
        stack.Push(root);
    }

    public bool HasMore()
    {
        return stack.Count > 0;
    }

    public FileSystemNode GetNext()
    {
        if (!HasMore()) return null;

        var current = stack.Pop();

        if (current is Folder Folder)
        {
            foreach (var element in Folder.Children.AsEnumerable().Reverse())
            {
                stack.Push(element);
            }
        }

        return current;
    }
}

