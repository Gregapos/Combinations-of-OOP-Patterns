public class ComputerAssemblyDirector
{
    public void ConstructComputer(IComputerBuilder builder)
    {
        builder.BuildProcessor();
        builder.BuildMemory();
        builder.BuildStorage();
    }

}
