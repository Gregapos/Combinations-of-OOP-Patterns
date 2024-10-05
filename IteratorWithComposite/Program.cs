using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        var root = new Folder("root");
        var subDir1 = new Folder("subDir1");
        var subDir2 = new Folder("subDir2");
        var file1 = new File("file1");
        var file2 = new File("file2");
        var file3 = new File("file3");

        subDir1.Add(file1);
        subDir2.Add(file2);
        root.Add(subDir1);
        root.Add(subDir2);
        root.Add(file3);

        var depthFirstIterator = root.createDFIterator();

        while (depthFirstIterator.HasMore())
        {
            var item = depthFirstIterator.GetNext();
            Console.WriteLine($"Traversed item: {item.Name}");
        }
    }
}
