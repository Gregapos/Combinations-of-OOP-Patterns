public abstract class Employee {
    protected string name;
    public abstract void Accept(IEmployeeVisitor visitor);
}

public class Developer : Employee {
    public Developer(string name) {
        this.name = name;
    }

    public override void Accept(IEmployeeVisitor visitor) {
        visitor.VisitDeveloper(this);
    }

    public void WriteCode() {
        Console.WriteLine($"{name} is writing code.");
    }
}

public class Designer : Employee {
    public Designer(string name) {
        this.name = name;
    }

    public override void Accept(IEmployeeVisitor visitor) {
        visitor.VisitDesigner(this);
    }

    public void Design() {
        Console.WriteLine($"{name} is designing.");
    }
}

public class Department : Employee {
    private List<Employee> _employees = new List<Employee>();

    public Department(string name) {
        this.name = name;
    }

    public string GetName(){
        return name;
    }

    public override void Accept(IEmployeeVisitor visitor) {
        visitor.VisitDepartment(this);
        foreach (var employee in _employees) {
            employee.Accept(visitor);
        }
    }

    public void AddEmployee(Employee employee) {
        _employees.Add(employee);
    }
}