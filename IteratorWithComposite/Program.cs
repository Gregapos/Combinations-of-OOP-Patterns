public class Program
{
    public static void Main(){
        var root = new Directory("Root");
        var subDir1 = new Directory("SubDir1");
        var subDir2 = new Directory("SubDir2");
        var file1 = new File("File1");
        var file2 = new File("File2");

        root.Add(subDir1);
        root.Add(subDir2);
        subDir1.Add(file1);
        subDir2.Add(file2);

        // Using DepthFirstFileIterator
        var depthFirstIterator = new DepthFirstFileIterator(root);
        while (depthFirstIterator.HasMore())
        {
            var item = depthFirstIterator.GetNext();
            item.Execute();
        }

        // // Using BreadthFirstFileIterator
        // var breadthFirstIterator = new BreadthFirstFileIterator(root);
        // while (breadthFirstIterator.HasNext())
        // {
        //     var item = breadthFirstIterator.Next();
        //     item.Display();
        // }
    }
}
