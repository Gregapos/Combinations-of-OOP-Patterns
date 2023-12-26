// Concrete Builders
public class ComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();
    private IComputerComponentFactory componentFactory; // Added field

     public ComputerBuilder(IComputerComponentFactory factory)
    {
        componentFactory = factory;
    }

    public void BuildProcessor()
    {
        computer.AddPart(componentFactory.CreateProcessor().GetType().Name);
    }

    public void BuildMemory()
    {
        computer.AddPart(componentFactory.CreateMemory().GetType().Name);
    }

    public void BuildStorage()
    {
        computer.AddPart(componentFactory.GetCreateStorage().GetType().Name);
    }

    public void SetComponentFactory(IComputerComponentFactory factory)
    {
        componentFactory = factory;
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

public class HighPerformanceComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();
    private IComputerComponentFactory componentFactory; // Added field

    public HighPerformanceComputerBuilder(IComputerComponentFactory factory)
    {
        componentFactory = factory;
    }

    public void BuildProcessor()
    {
        computer.AddPart(componentFactory.CreateProcessor().GetType().Name);
    }

    public void BuildMemory()
    {
        computer.AddPart(componentFactory.CreateMemory().GetType().Name);
    }

    public void BuildStorage()
    {
        computer.AddPart(componentFactory.GetCreateStorage().GetType().Name);
    }

    public void SetComponentFactory(IComputerComponentFactory factory)
    {
        componentFactory = factory;
    }

    public Computer GetComputer()
    {
        return computer;
    }
}