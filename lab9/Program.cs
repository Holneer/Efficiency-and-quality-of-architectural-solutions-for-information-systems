using lab9;

var employee1 = new Employee("Developer", 5000);
var employee2 = new Employee("Manager", 7000);
var employee3 = new Employee("QA", 4500);

var department1 = new Department("ITDepartment", new List<Employee> { employee1, employee3 });
var department2 = new Department("Management", new List<Employee> { employee2 });

var company = new Company("Solutions", new List<Department> { department1, department2 });

var companyVisitor = new SalaryReportVisitor();
company.Accept(companyVisitor);
Console.WriteLine($"Загальна сума зарплат у компанії: {companyVisitor.GetTotalSalary()}");

var departmentVisitor = new SalaryReportVisitor();
department1.Accept(departmentVisitor);
Console.WriteLine($"Загальна сума зарплат у департаменті '{department1.Name}': {departmentVisitor.GetTotalSalary()}");