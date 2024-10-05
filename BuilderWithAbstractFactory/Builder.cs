using System.Linq;
using System.Reflection.Metadata.Ecma335;

public interface Builder
{
    public void Reset();
    public void SetFactory(AbstractFactory factory);
    public void BuildCPU();
    public void BuildMemory();
    public void BuildStorage();
    public Product GetResult();

}

public class ComputerBuilder : Builder
{
    private Product result;
    private AbstractFactory factory;
    public void Reset()
    {
        this.result = new Product();
    }
    public void SetFactory(AbstractFactory factory)
    {
        this.factory = factory;
    }
    public void BuildCPU() => result.AddPart(factory.CreateCPU());
    public void BuildMemory() => result.AddPart(factory.CreateMemory());
    public void BuildStorage() => result.AddPart(factory.CreateStorage());
    public Product GetResult() => result;
}
