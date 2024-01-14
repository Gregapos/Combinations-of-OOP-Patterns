public class DataProcessingService
{
    public void Validate(DataRequest request)
    {
        Console.WriteLine($"Service: Validating {request.Data}.");
        request.Data = $"validated {request.Data}";
    }

    public void Transform(DataRequest request)
    {
        Console.WriteLine($"Service: Transforming {request.Data}.");
        request.Data = $"transformed {request.Data}";
    }

    public void Enrich(DataRequest request)
    {
        Console.WriteLine($"Service: Enriching {request.Data}.");
        request.Data = $"enriched {request.Data}";
    }

    public void Process(DataRequest request)
    {
        Console.WriteLine($"Service: Final processing of {request.Data}.");
    }
}
