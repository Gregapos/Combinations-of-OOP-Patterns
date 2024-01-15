public interface IDepartmentHandler
{
    IDepartmentHandler SetNext(IDepartmentHandler handler);
    void SignDocument(DocumentSigningCommand command);
}

// Base DepartmentHandler
public abstract class BaseDepartmentHandler : IDepartmentHandler
{
    private IDepartmentHandler _nextHandler;

    public IDepartmentHandler SetNext(IDepartmentHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void SignDocument(DocumentSigningCommand command)
    {
        _nextHandler?.SignDocument(command);
    }
}

// Concrete Handlers
public class HRDepartment : BaseDepartmentHandler
{
    public override void SignDocument(DocumentSigningCommand command)
    {
        command.Execute("HR Department Signature");
        base.SignDocument(command);
    }
}

public class FinanceDepartment : BaseDepartmentHandler
{
    public override void SignDocument(DocumentSigningCommand command)
    {
        command.Execute("Finance Department Signature");
        base.SignDocument(command);
    }
}

public class LegalDepartment : BaseDepartmentHandler
{
    public override void SignDocument(DocumentSigningCommand command)
    {
        command.Execute("Legal Department Signature");
        base.SignDocument(command);
    }
}
