public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> heap = new List<T>();

    public int Count => heap.Count;

    public PriorityQueue() { }

    public PriorityQueue(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Enqueue(item);
        }
    }
    
    public void Enqueue(T item)
    {
        heap.Add(item);
        int i = heap.Count - 1;
        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (item.CompareTo(heap[parent]) >= 0)
                break;

            heap[i] = heap[parent];
            i = parent;
        }
        heap[i] = item;
    }

    public T Dequeue()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("PriorityQueue is empty.");

        T root = heap[0];
        int last = heap.Count - 1;
        T lastItem = heap[last];
        heap.RemoveAt(last);
        if (heap.Count > 0)
        {
            int i = 0;
            while (true)
            {
                int left = 2 * i + 1;
                if (left > last)
                    break;

                int right = left + 1;
                int smallestChild = left;
                if (right <= last && heap[right].CompareTo(heap[left]) < 0)
                    smallestChild = right;

                if (lastItem.CompareTo(heap[smallestChild]) <= 0)
                    break;

                heap[i] = heap[smallestChild];
                i = smallestChild;
            }
            heap[i] = lastItem;
        }
        return root;
    }
}