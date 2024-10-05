interface ICollectionCreator<T> where T : IComparable<T>
{
    IIterator<T> CreateIterator();
}

class ListCreator<T> : ICollectionCreator<T> where T : IComparable<T>
{
    private List<T> collection;

    public ListCreator(List<T> collection)
    {
        this.collection = collection;
    }

    public IIterator<T> CreateIterator()
    {
        return new ListIterator<T>(collection);
    }
}

class HeapCreator<T> : ICollectionCreator<T> where T : IComparable<T>
{
    private PriorityQueue<T> collection;

    public HeapCreator(PriorityQueue<T> collection)
    {
        this.collection = collection;
    }

    public IIterator<T> CreateIterator()
    {
        return new HeapIterator<T>(collection);
    }
}