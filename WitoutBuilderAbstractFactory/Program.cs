
class Program
{
    static void Main()
    {
        Computer gamingComputer = new Computer();
        gamingComputer.BuildGamingComputer();
        gamingComputer.ToString();

        Computer standardComputer = new Computer();
        standardComputer.BuildStandardComputer();
        standardComputer.ToString();
    }
}
