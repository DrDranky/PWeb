using System.Collections.Generic;
using System.Xml;

namespace Ex2
{
    public class Company
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void AddEmployee(string name, int nif, double sales, double salesCommission, double wage = 0)
        {
            _employees.Add(wage == 0
                ? new Employee(name, nif, sales, salesCommission)
                : new EmployeeWithWage(name, nif, sales, salesCommission, wage));
        }

        public string ShowWages()
        {
            string wages = null;
            foreach (var employee in _employees)
            {
                wages += employee.ToString();
            }

            return wages;
        }
    }
}