namespace Ex4
{
    public class EmployeeWithCommission : Employee
    {
        protected readonly double Sales, SalesCommission;

        public EmployeeWithCommission(string name, int nif, double sales, double salesCommission) 
            : base(name, nif)
        {
            Sales = sales;
            SalesCommission = salesCommission;
        }
        
        protected override double FinalWage()
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