using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public interface IVisitor
    {
        void VisitCompany(Company company);
        void VisitDepartment(Department department);
        void VisitEmployee(Employee employee);
    }
}