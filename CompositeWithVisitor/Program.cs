class Program {
    static void Main() {
        //structure creation
        Department softwareDepartment = new Department("Software Department");
        softwareDepartment.AddEmployee(new Developer("Raj"));
        softwareDepartment.AddEmployee(new Designer("Bob"));

        Department designDepartment = new Department("Design Department");
        designDepartment.AddEmployee(new Designer("Alice"));

        Department company = new Department("Tech Company");
        company.AddEmployee(softwareDepartment);
        company.AddEmployee(designDepartment);

        //visitor
        DepartmentVisitor visitor = new DepartmentVisitor();
        company.Accept(visitor);
    }
}
