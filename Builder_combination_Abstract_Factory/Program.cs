class Program
{
    static void Main()
    {
        ComputerAssemblyDirector director = new ComputerAssemblyDirector();

        // Using Abstract Factory with Builder for a Gaming Computer
        IComputerComponentFactory gamingFactory = new GamingComputerComponentFactory();
        IComputerBuilder gamingBuilder = new HighPerformanceComputerBuilder(gamingFactory);
        
        // Set the builder's factory to the chosen factory
       // ((HighPerformanceComputerBuilder)gamingBuilder).SetComponentFactory(gamingFactory);

        // Construct the computer
        director.ConstructComputer(gamingBuilder);
        Computer gamingComputer = gamingBuilder.GetComputer();
        gamingComputer.Show();

        // Using Abstract Factory with Builder for an Office Computer
        IComputerComponentFactory officeFactory = new OfficeComputerComponentFactory();
        IComputerBuilder officeBuilder = new ComputerBuilder(officeFactory);

        // Set the builder's factory to the chosen factory
        //((ComputerBuilder)officeBuilder).SetComponentFactory(officeFactory);

        // Construct the computer
        director.ConstructComputer(officeBuilder);
        Computer officeComputer = officeBuilder.GetComputer();
        officeComputer.Show();
        

    }
}
