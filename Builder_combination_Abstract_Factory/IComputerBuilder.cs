// Builder Interface
public interface IComputerBuilder
{
    void BuildProcessor();
    void BuildMemory();
    void BuildStorage();
    void SetComponentFactory(IComputerComponentFactory factory); // Added method
    Computer GetComputer();
}