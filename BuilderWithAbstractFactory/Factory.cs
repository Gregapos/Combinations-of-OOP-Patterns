public interface AbstractFactory
{
    public Memory CreateMemory();
    public CPU CreateCPU();
    public Storage CreateStorage();
}

public class HIghEndFactory : AbstractFactory
{
    public Memory CreateMemory()
    {
        return new FastMemory();
    }
    public CPU CreateCPU()
    {
        return new GamingCPU();
    }
    public Storage CreateStorage()
    {
        return new SSDStorage();
    }

}

public class StandardFactory : AbstractFactory
{
    public Memory CreateMemory()
    {
        return new SlowMemory();
    }
    public CPU CreateCPU()
    {
        return new StandardCPU();
    }
    public Storage CreateStorage()
    {
        return new HDDStorage();
    }
}