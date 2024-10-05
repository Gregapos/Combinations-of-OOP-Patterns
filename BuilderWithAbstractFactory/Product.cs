using System.Runtime;

public class Product
{
    private List<Part> parts = new List<Part>();

    public void AddPart(Part part)
    {
        parts.Add(part);
    }

    public void ToString()
    {
        Console.WriteLine("\nComputer contains: ");
        foreach (var part in parts)
        {
            Console.WriteLine(part.Type);
        }
    }
}