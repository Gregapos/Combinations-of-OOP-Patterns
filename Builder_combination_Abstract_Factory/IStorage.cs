public interface IStorage
{
    string Type { get; }
}

public class HDDStorage : IStorage
{
    public string Type => "HDD Storage";
}

public class SSDStorage : IStorage
{
    public string Type => "SSD Storage";
}
