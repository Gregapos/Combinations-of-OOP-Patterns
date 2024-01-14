public interface ICommand
{
    void Execute(DataRequest request);
}

public abstract class BaseCommand : ICommand
{
    protected ICommand _nextCommand;
    protected DataProcessingService _service;

    public abstract void Execute(DataRequest request);
}

public class ValidationCommand : BaseHandler
{
    public ValidationCommand(ICommand nextCommand, DataProcessingService service)
    {
        _nextCommand = nextCommand;
        _service = service;
    }

    public override void Execute(DataRequest request)
    {
        _service.Validate(request);
        _nextCommand?.Execute(request);
    }
}

public class TransformationCommand : BaseHandler
{
    public TransformationCommand(ICommand nextCommand, DataProcessingService service)
    {
        _service = service;
        _nextCommand = nextCommand;
    }

    public override void Execute(DataRequest request)
    {
        _service.Transform(request);
        _nextCommand?.Execute(request);
    }
}

public class EnrichmentCommand : BaseHandler
{
    public EnrichmentCommand(ICommand nextCommand, DataProcessingService service)
    {
        _nextCommand = nextCommand;
        _service = service;
    }

    public override void Execute(DataRequest request)
    {
        _service.Enrich(request);
        _nextCommand?.Execute(request);
    }
}

public class FinalProcessingCommand : BaseHandler
{
    public FinalProcessingCommand(ICommand nextCommand, DataProcessingService service)
    {
        _service = service;
    }
    
    public override void Execute(DataRequest request)
    {
        _service.Process(request);
        _nextCommand?.Execute(request);
    }
}
