public interface ICommand
{
    void Execute(DataRequest request);
}

public abstract class BaseCommand : ICommand
{
    protected ICommand _nextCommand;
    protected DataProcessingService _service;

    public virtual void Execute(DataRequest request)
    {
        _nextCommand?.Execute(request);
    }
}

public class ValidationCommand : BaseCommand
{
    public ValidationCommand(ICommand nextCommand, DataProcessingService service)
    {
        _nextCommand = nextCommand;
        _service = service;
    }

    public override void Execute(DataRequest request)
    {
        _service.Validate(request);
        base.Execute(request);
    }
}

public class TransformationCommand : BaseCommand
{
    public TransformationCommand(ICommand nextCommand, DataProcessingService service)
    {
        _service = service;
        _nextCommand = nextCommand;
    }

    public override void Execute(DataRequest request)
    {
        _service.Transform(request);
        base.Execute(request);
    }
}

public class EnrichmentCommand : BaseCommand
{
    public EnrichmentCommand(ICommand nextCommand, DataProcessingService service)
    {
        _nextCommand = nextCommand;
        _service = service;
    }

    public override void Execute(DataRequest request)
    {
        _service.Enrich(request);
        base.Execute(request);
    }
}

public class FinalProcessingCommand : BaseCommand
{
    public FinalProcessingCommand(ICommand nextCommand, DataProcessingService service)
    {
        _service = service;
    }

    public override void Execute(DataRequest request)
    {
        _service.Process(request);
        base.Execute(request);
    }
}
