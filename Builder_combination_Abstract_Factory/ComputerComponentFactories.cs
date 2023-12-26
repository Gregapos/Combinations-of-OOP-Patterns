public class GamingComputerComponentFactory : IComputerComponentFactory
{
    public IProcessor CreateProcessor()
    {
        return new HighPerformanceProcessor();
    }

    public IMemory CreateMemory()
    {
        return new HighCapacityMemory();
    }

    public IStorage GetCreateStorage()
    {
        return new SSDStorage();
    }
}

public class OfficeComputerComponentFactory : IComputerComponentFactory
{
    public IProcessor CreateProcessor()
    {
        return new StandardProcessor();
    }

    public IMemory CreateMemory()
    {
        return new StandardMemory();
    }

    public IStorage GetCreateStorage()
    {
        return new HDDStorage();
    }
}