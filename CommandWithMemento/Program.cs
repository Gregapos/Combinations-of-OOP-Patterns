class Program
{
    static void Main(string[] args)
    {
        TextService service = new TextService();
        CommandInvoker invoker = new CommandInvoker();


        invoker.Execute(new AddTextCommand(service, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
        invoker.Execute(new AddTextCommand(service, "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s."));

        Console.WriteLine("Content: " + service.Content);

        while (!invoker.IsEmpty())
        {
            invoker.Undo();
            Console.WriteLine("After Undo: " + service.Content);
        }
    }
}
