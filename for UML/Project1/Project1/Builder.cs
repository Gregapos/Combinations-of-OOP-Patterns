namespace project1
{

    public interface Builder
    {
        void Reset();
        void SetFactory(AbstractFactory factory);
        void BuildCPU();
        void BuildMemory();
        void BuildStorage();
        void BuildGPU();
        Product GetResult();

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
        public void BuildCPU() => result.AddPart(factory.createCPU());
        public void BuildMemory() => result.AddPart(factory.createMemory());
        public void BuildStorage() => result.AddPart(factory.createStorage());
        public void BuildGPU() => result.AddPart(factory.createGPU());
        public Product GetResult() => result;
    }

}


