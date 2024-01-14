public class Program
{
    public static void Main()
    {
        var request = new DataRequest { Data = "Sample Data" };
        var service = new DataProcessingService();

        // Set up the chain
        ICommand finalProcessing = new FinalProcessingCommand(null, service);
        ICommand enrichment = new EnrichmentCommand(finalProcessing, service);
        ICommand transformation = new TransformationCommand(enrichment, service);
        ICommand validation = new ValidationCommand(transformation, service);

        // Start the chain
        validation.Execute(request);
    }
}
