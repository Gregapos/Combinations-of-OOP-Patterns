public interface Part
{
    string Type { get; }
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

public interface CPU : Part
{
    string Type { get; }
}

public class GamingCPU : CPU
{
    public string Type => "Gaming Processor";
}

public class StandardCPU : CPU
{
    public string Type => "Standard Processor";
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
