using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public class SalaryReportVisitor : IVisitor
    {
        private decimal _totalSalary = 0;

        public void VisitCompany(Company company)
        {
            Console.WriteLine($"Генерація зарплатної відомості для компанії {company.Name}.");
        }

        public void VisitDepartment(Department department)
        {
            Console.WriteLine($"Генерація зарплатної відомості для департаменту {department.Name}.");
        }

        public void VisitEmployee(Employee employee)
        {
            _totalSalary += employee.Salary;
            Console.WriteLine($"Позиція: {employee.Position}, Зарплата: {employee.Salary}");
        }

        public decimal GetTotalSalary()
        {
            return _totalSalary;
        }
    }
}