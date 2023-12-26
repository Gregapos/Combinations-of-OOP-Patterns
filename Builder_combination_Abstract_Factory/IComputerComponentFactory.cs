public interface IComputerComponentFactory
{
    IProcessor CreateProcessor();
    IMemory CreateMemory();
    IStorage GetCreateStorage();
}