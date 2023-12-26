public interface Part
{
    string Type { get; }
}

public interface ProcessorInt : Part
{
    string Type { get; }
}

public class GamingCPU : ProcessorInt
{
    public string Type => "Gaming Processor";
}

public class StandardCPU : ProcessorInt
{
    public string Type => "Standard Processor";
}

public interface Memory : Part
{
    string Type { get; }
}

public class FastMemory : Memory
{
    public string Type => "3200Mhz Memory";
}

public class SlowMemory : Memory
{
    public string Type => "1333Mhz Memory";
}

public interface Storage : Part
{
    string Type { get; }
}

public class HDDStorage : Storage
{
    public string Type => "HDD Storage";
}

public class SSDStorage : Storage
{
    public string Type => "SSD Storage";
}
