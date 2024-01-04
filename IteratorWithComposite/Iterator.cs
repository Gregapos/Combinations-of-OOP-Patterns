public interface IIterator
{
    bool HasMore();
    IFileSystemItem GetNext();
}

public class DepthFirstFileIterator : IIterator
{
    private Stack<IFileSystemItem> stack = new Stack<IFileSystemItem>();

    public DepthFirstFileIterator(Directory root)
    {
        stack.Push(root);
    }

    public bool HasMore()
    {
        return stack.Count > 0;
    }

    public IFileSystemItem GetNext()
    {
        if (!HasMore()) return null;

        var current = stack.Pop();

        //current.PushItemToStack(stack);
        if (current is Directory directory)
        {
            foreach (var element in directory.GetItems().AsEnumerable().Reverse())
            {
                stack.Push(element);
            }
        }

        return current;
    }
}

