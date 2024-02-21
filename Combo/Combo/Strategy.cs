public interface IStrategy
{
    public void Alert();
}

public class AlertPoliceStrategy : IStrategy
{
    public void Alert()
    {
        Console.WriteLine("Calling Police");
    }
}

public class SirenStrategy : IStrategy
{
    public void Alert()
    {
        Console.WriteLine("**Siren Noise**");
    }
}

