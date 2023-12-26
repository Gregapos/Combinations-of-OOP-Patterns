interface IIterator<T>
{
    bool HasMore();
    T GetNext();
}

class ListIterator<T> : IIterator<T>
{
    private List<T> collection;
    private int index = 0;

    public ListIterator(List<T> collection)
    {
        this.collection = collection;
    }

    public bool HasMore()
    {
        return index < collection.Count;
    }

    public T GetNext()
    {
        if (HasMore())
        {
            return collection[index++];
        }
        throw new InvalidOperationException("No more elements in the collection.");
    }
}

class HeapIterator<T> : IIterator<T>
{
    private PriorityQueue<T> collection;

    public HeapIterator(PriorityQueue<T> collection)
    {
        this.collection = collection;
    }

    public bool HasMore()
    {
        return collection.Count > 0;
    }

    public T GetNext()
    {
        if (HasMore())
        {
            return collection.Dequeue();
        }
        throw new InvalidOperationException("No more elements in the collection.");
    }
}

