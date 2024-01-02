public interface IFileSystemIterator
{
    bool HasMore();
    IFileSystemItem GetNext();
}

public class DepthFirstFileIterator : IFileSystemIterator
{
    private Stack<IFileSystemItem> stack = new Stack<IFileSystemItem>();

    public DepthFirstFileIterator(IFileSystemItem root)
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

        current.PushItemToStack(stack);

        return current;
    }
}

// public class BreadthFirstFileIterator : IFileSystemIterator
// {
//     private Queue<IFileSystemItem> queue = new Queue<IFileSystemItem>();

//     public BreadthFirstFileIterator(IFileSystemItem root)
//     {
//         queue.Enqueue(root);
//     }

//     public bool HasMore()
//     {
//         return queue.Count > 0;
//     }

//     public IFileSystemItem GetNext()
//     {
//         if (!HasMore()) return null;

//         var current = queue.Dequeue();
//         for (int i = 0; i < current.GetItemCount(); i++)
//         {
//             queue.Enqueue(current.GetItem(i));
//         }
//         return current;
//     }
// }
