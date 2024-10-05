class Program
{
    static void Main()
    {
        ComputerBuilder builder = new ComputerBuilder();
        Director director = new Director(builder);
        director.Make("gaming");
        builder.GetResult().ToString();
    }
}

