namespace project1
{
    public interface Part
    {
        string Type { get; }
    }
    public interface Memory : Part
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        string Type { get; }
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    }

    public class FastMemory : Memory
    {
        public string Type => "3200Mhz Memory";
    }

    public class SlowMemory : Memory
    {
        public string Type => "1333Mhz Memory";
    }

    public interface ProcessorInt : Part
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        string Type { get; }
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    }

    public class GamingCPU : ProcessorInt
    {
        public string Type => "Gaming Processor";
    }

    public class StandardCPU : ProcessorInt
    {
        public string Type => "Standard Processor";
    }

    public interface Storage : Part
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        string Type { get; }
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    }

    public class HDDStorage : Storage
    {
        public string Type => "HDD Storage";
    }

    public class SSDStorage : Storage
    {
        public string Type => "SSD Storage";
    }
}