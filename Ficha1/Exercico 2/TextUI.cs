using System;

namespace Ex2
{
    public class TextUi
    {
        private readonly Company _company;
        
        public TextUi(Company company)
        {
            _company = company;
        }


        public void Start()
        {
            //just for test
            _company.AddEmployee("Barbatana da Costa", 987987987, 10000.00,0.06);
            _company.AddEmployee("Pateta Alegre", 123123123, 5000.00,0.06,600);
            _company.AddEmployee("Bob", 696969696, 9000.00,0.1,2000);
            Console.WriteLine(_company.ShowWages());
        }
    }
}