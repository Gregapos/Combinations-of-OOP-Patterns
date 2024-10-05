public class DocumentService
{
    public void Sign(Document document, string signature)
    {
        document.signatures.Add(signature);
        Console.WriteLine($"Service: Added {signature} to document {document.Name}.");
    }
}
