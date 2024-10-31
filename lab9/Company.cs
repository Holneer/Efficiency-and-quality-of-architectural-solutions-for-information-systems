using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public class Company : IVisitable
    {
        public string Name { get; }
        public List<Department> Departments { get; }

        public Company(string name, List<Department> departments)
        {
            Name = name;
            Departments = departments;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompany(this);
            foreach (var department in Departments)
            {
                department.Accept(visitor);
            }
        }
    }
}