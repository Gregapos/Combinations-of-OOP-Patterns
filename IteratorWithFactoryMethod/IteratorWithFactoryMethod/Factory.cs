interface ICollectionCreator<T>
{
    IIterator<T> CreateIterator();
}

class ListCreator<T> : ICollectionIteratorFactory<T>
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

class HeapCreator<T> : ICollectionIteratorFactory<T>
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