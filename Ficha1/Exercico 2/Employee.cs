using System.Runtime.InteropServices;

namespace Ex2
{
    public class Employee
    {
        protected readonly string Name;
        protected readonly int Nif;
        protected readonly double Sales, SalesCommission;

        public Employee(string name, int nif, double sales, double salesCommission)
        {
            Name = name;
            Nif = nif;
            Sales = sales;
            SalesCommission = salesCommission;
        }

        protected virtual double FinalWage()
        {
            return Sales * SalesCommission;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                   "\nNIF: " + Nif +
                   "\nTotal Sales: " + Sales +
                   "\nSales Commission: " + SalesCommission +
                   "\nFinal Wage: " + FinalWage() + "\n\n";
        }
    }
}