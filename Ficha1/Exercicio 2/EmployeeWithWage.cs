namespace Ex2
{
    public class EmployeeWithWage : Employee
    {
        private readonly double _wage;
        public EmployeeWithWage(string name, int nif, double sales, double salesCommission, double wage) 
            : base(name, nif, sales, salesCommission)
        {
            _wage = wage;
        }

        protected override double FinalWage()
        {
            return Sales * SalesCommission + _wage;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                   "\nNIF: " + Nif +
                   "\nTotal Sales: " + Sales +
                   "\nSales Commission: " + SalesCommission +
                   "\nBase Wage: " + _wage +
                   "\nFinal Wage: " + FinalWage() + "\n\n";
        }
    }
}