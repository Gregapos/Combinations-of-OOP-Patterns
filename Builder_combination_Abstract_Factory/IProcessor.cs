public interface IProcessor
{
    string Model { get; }
}

public class StandardProcessor : IProcessor
{
    public string Model => "Standard Processor";
}

public class HighPerformanceProcessor : IProcessor
{
    public string Model => "High-Performance Processor";
}
