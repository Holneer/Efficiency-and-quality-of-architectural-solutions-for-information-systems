using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public class Employee : IVisitable
    {
        public string Position { get; }
        public decimal Salary { get; }

        public Employee(string position, decimal salary)
        {
            Position = position;
            Salary = salary;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }
    }
}