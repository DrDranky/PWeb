using System.Collections.Generic;
using System.Xml;

namespace Ex4
{
    public class Company
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void AddEmployee(string name, int nif, double sales, double salesCommission, double wage, double bonus)
        {
            _employees.Add(new EmployeeWithWage(name, nif, sales, salesCommission, wage, bonus));
        }
        
        public void AddEmployee(string name, int nif, double wage)
        {
            _employees.Add(new EmployeeWithWage(name, nif, 0, 0, wage, 0));
        }

        public void AddEmployee(string name, int nif, double sales, double salesCommission)
        {
            _employees.Add(new EmployeeWithCommission(name, nif, sales, salesCommission));
        }
        
        public void AddEmployee(string name, int nif, double paymentPerHour, int daysOfWork, int hoursOfWork)
        {
            _employees.Add(new EmployeeWithWagePerHour(name, nif, daysOfWork,paymentPerHour,hoursOfWork));
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