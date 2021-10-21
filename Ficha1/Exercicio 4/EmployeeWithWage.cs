namespace Ex4
{
    public class EmployeeWithWage : EmployeeWithCommission
    {
        private readonly double _wage, _bonus;
        public EmployeeWithWage(string name, int nif, double sales, double salesCommission, double wage, double bonus) 
            : base(name, nif, sales, salesCommission)
        {
            _wage = wage;
            _bonus = bonus;
        }

        protected override double FinalWage()
        {
            return Sales * SalesCommission + _wage + _bonus;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                   "\nNIF: " + Nif +
                   "\nTotal Sales: " + Sales +
                   "\nSales Commission: " + SalesCommission +
                   "\nBase Wage: " + _wage +
                   "\nBase Wage with bonus: " + (_wage + _bonus) + 
                   "\nFinal Wage: " + FinalWage() + "\n\n";
        }
    }
}