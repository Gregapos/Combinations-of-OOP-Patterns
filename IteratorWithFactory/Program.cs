using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<int> listCollection = new List<int> { 1, 2 ,3 ,4 ,5 ,6 , };
        ICollectionCreator<int> listFactory = new ListCreator<int>(listCollection);
        IIterator<int> listIterator = listFactory.CreateIterator();

        Console.WriteLine("ListCollection elements:");
        while (listIterator.HasMore())
        {
            Console.Write(listIterator.GetNext() + " ");
        }
        Console.WriteLine();

        PriorityQueue<int> heapCollection = new PriorityQueue<int>(new[] { 7, 8, 9, 10, 11, 12 });
        ICollectionCreator<int> heapFactory = new HeapCreator<int>(heapCollection);
        IIterator<int> heapIterator = heapFactory.CreateIterator();

        Console.WriteLine("\nHeapCollection elements:");
        while (heapIterator.HasMore())
        {
            Console.Write(heapIterator.GetNext() + " ");
        }
    }
}

