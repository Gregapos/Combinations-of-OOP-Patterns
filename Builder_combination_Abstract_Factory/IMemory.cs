public interface IMemory
{
    string Type { get; }
}

public class StandardMemory : IMemory
{
    public string Type => "Standard Memory";
}

public class HighCapacityMemory : IMemory
{
    public string Type => "High-Capacity Memory";
}
