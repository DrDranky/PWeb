namespace Ex4
{
    public class EmployeeWithWagePerHour : Employee
    {
        private const int RegularHoursPerDay = 8;
        private const double RaisePerExtraHour = 1.5; //raise of 50% per extra hour
        private readonly int _daysOfWork;
        private readonly int _regularHoursOfWork;
        private readonly int _extraHoursOfWork;
        private readonly double _paymentPerHour;

        public EmployeeWithWagePerHour(string name, int nif, int daysOfWork,
            double paymentPerHour, int hoursOfWork) : base(name, nif)
        {
            _daysOfWork = daysOfWork;
            _paymentPerHour = paymentPerHour;
            _regularHoursOfWork = RegularHoursPerDay * daysOfWork;
            _extraHoursOfWork = hoursOfWork - _regularHoursOfWork;
        }
        
        protected override double FinalWage()
        {
            return _regularHoursOfWork * _paymentPerHour + _extraHoursOfWork * (_paymentPerHour * RaisePerExtraHour);
        }
        
        public override string ToString() => $"Name: {Name}\nNIF: {Nif}\n" +
                                             $"Payment Per Hour: {_paymentPerHour}\n" +
                                             $"Days of Work: {_daysOfWork}\n" +
                                             $"Hours of work: {(_extraHoursOfWork + _regularHoursOfWork)}\n" +
                                             $"Final Wage: {FinalWage()}\n\n";
    }
}