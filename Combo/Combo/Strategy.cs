public interface Strategy
{
    public void Alert();
}

public class AlertPoliceStrategy : Strategy
{
    public void Alert()
    {
        Console.WriteLine("Calling Police");
    }
}

public class SirenStrategy : Strategy
{
    public void Alert()
    {
        Console.WriteLine("**Siren Noise**");
    }
}

