class Program
{
    static void Main(string[] args)
    {
        var builder = new FileSystemBuilder("root")
        .BuildFolder("Folder0")
        .SetCurrentFolder("Folder0")
        .BuildFile("File_0_0.txt", 12000)
        .BuildFile("File_0_1.mkv", 1000000)
        .BuildFolder("SubFolder0_0")
        .SetCurrentFolder("SubFolder0_0")
        .BuildFile("File_0_0_0.mp3", 20000)
        .BuildFile("File_0_0_1.pdf", 18000)
        .SetCurrentFolder("root")
        .BuildFolder("Folder1")
        .BuildFile("File_1_0.apk", 250000)
        .BuildFile("File_1_1.exe", 87000000)
        .Build();

        Console.WriteLine($"Total size of (root): {builder.GetSize()} Bytes");
    }
}