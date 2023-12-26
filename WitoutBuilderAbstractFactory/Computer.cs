public class Computer
{
    private List<Part> parts = new List<Part>();

    public void BuildGamingComputer()
    {
        Reset();
        parts.Add(new GamingCPU());
        parts.Add(new FastMemory());
        parts.Add(new SSDStorage());
    }

    public void BuildStandardComputer()
    {
        Reset();
        parts.Add(new StandardCPU());
        parts.Add(new SlowMemory());
        parts.Add(new HDDStorage());
    }

    public void Reset()
    {
        parts = new List<Part>();
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