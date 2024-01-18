class Program
{
    public static void Main(string[] args)
    {
        var documentService = new DocumentService();
        var hr = new HRDepartment();
        var finance = new FinanceDepartment();
        var legal = new LegalDepartment();

        hr.SetNext(finance).SetNext(legal);

        var document = new Document("Report", "Report content");
        var signingCommand = new DocumentSigningCommand(document, documentService);

        // Passing the command through the chain
        hr.SignDocument(signingCommand);
    }
}