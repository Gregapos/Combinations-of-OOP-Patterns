public class Document
{
    public string Name { get; set; }
    public string Content { get; set; }
    public List<string> signatures = new List<string>();

    public Document(string name, string content)
    {
        Name = name;
        Content = content;
    }
}

public interface ICommand
{
    void Execute(string signature);
}

public class DocumentSigningCommand : ICommand
{
    private DocumentService _service;
    private Document _document;

    public DocumentSigningCommand(Document document, DocumentService service)
    {
        _service = service;
        _document = document;
    }

    public void Execute(string signature)
    {
        _service.Sign(_document, signature);
    }
}