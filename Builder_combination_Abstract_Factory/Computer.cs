public class Computer
{
    private List<string> parts = new List<string>();

    public void AddPart(string part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("Computer parts: " + string.Join(", ", parts));
    }
}