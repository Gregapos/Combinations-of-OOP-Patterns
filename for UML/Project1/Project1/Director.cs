namespace project1
{

    public class Director
    {
        Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Make(string type)
        {
            builder.Reset();
            if (type == "gaming") builder.SetFactory(new HIghEndFactory());
            else if (type == "standard") builder.SetFactory(new StandardFactory());

            builder.BuildCPU();
            builder.BuildMemory();
            builder.BuildStorage();
            //builder.SetFactory(new HIghEndFactory());
            builder.BuildGPU();
            //Console.WriteLine(builder.getResult().details);
        }

    }
}