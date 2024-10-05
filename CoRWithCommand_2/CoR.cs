public interface IDepartmentHandler
{
    public IDepartmentHandler SetNext(IDepartmentHandler handler);
    public void SignDocument(ICommand command);
}

public abstract class BaseDepartmentHandler : IDepartmentHandler
{
    private IDepartmentHandler _nextHandler;

    public IDepartmentHandler SetNext(IDepartmentHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void SignDocument(ICommand command)
    {
        _nextHandler?.SignDocument(command);
    }
}

public class HRDepartment : BaseDepartmentHandler
{
    public override void SignDocument(ICommand command)
    {
        command.Execute("HR Department Signature");
        base.SignDocument(command);
    }
}

public class FinanceDepartment : BaseDepartmentHandler
{
    public override void SignDocument(ICommand command)
    {
        command.Execute("Finance Department Signature");
        base.SignDocument(command);
    }
}

public class LegalDepartment : BaseDepartmentHandler
{
    public override void SignDocument(ICommand command)
    {
        command.Execute("Legal Department Signature");
        base.SignDocument(command);
    }
}
