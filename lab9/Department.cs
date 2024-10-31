using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public class Department : IVisitable
    {
        public string Name { get; }
        public List<Employee> Employees { get; }

        public Department(string name, List<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitDepartment(this);
            foreach (var employee in Employees)
            {
                employee.Accept(visitor);
            }
        }
    }
}