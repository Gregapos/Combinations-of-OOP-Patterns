namespace project1
{

    public interface AbstractFactory
    {
        Memory createMemory();
        ProcessorInt createCPU();
        Storage createStorage();
        GPU createGPU();
    }

    public class HIghEndFactory : AbstractFactory
    {
        public Memory createMemory()
        {
            return new FastMemory();
        }
        public ProcessorInt createCPU()
        {
            return new GamingCPU();
        }
        public Storage createStorage()
        {
            return new SSDStorage();
        }
        public GPU createGPU()
        {
            return new ExternalGPU();
        }
    }

    public class StandardFactory : AbstractFactory
    {
        public Memory createMemory()
        {
            return new SlowMemory();
        }
        public ProcessorInt createCPU()
        {
            return new StandardCPU();
        }
        public Storage createStorage()
        {
            return new HDDStorage();
        }
        public GPU createGPU()
        {
            return new EmbeddedGPU();
        }
    }
}