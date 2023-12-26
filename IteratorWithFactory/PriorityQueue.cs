using System.Collections.Generic;
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

    public void Enqueue(T x)
    {
        heap.Add(x);
        int i = Count - 1;

        while (i > 0)
        {
            int p = (i - 1) / 2;
            if ( heap[p].CompareTo(x) <= 0) break;

            heap[i] = heap[p];
            i = p;
        }

        if (Count > 0) heap[i] = x;
    }

    public T Dequeue()
    {
        T target = Peek();
        T root = heap[Count - 1];
        heap.RemoveAt(Count - 1);

        int i = 0;
        while (i * 2 + 1 < Count)
        {
            int a = i * 2 + 1;
            int b = i * 2 + 2;
            int c = b < Count && heap[b].CompareTo(heap[a]) < 0 ? b : a;

            if (heap[c].CompareTo(root) >= 0) break;
            heap[i] = heap[c];
            i = c;
        }

        if (Count > 0) heap[i] = root;
        return target;
    }
    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Queue is empty.");
        return heap[0];
    }

}