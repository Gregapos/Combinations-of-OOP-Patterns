public interface IEmployeeVisitor {
    void VisitDeveloper(Developer developer);
    void VisitDesigner(Designer designer);
    void VisitDepartment(Department department);
}

public class DepartmentVisitor : IEmployeeVisitor {
    public void VisitDeveloper(Developer developer) {
        developer.WriteCode();
    }

    public void VisitDesigner(Designer designer) {
        designer.Design();
    }

    public void VisitDepartment(Department department) {
        Console.WriteLine($"Evaluating department: {department.GetName()}");
    }
}