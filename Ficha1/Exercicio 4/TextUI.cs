using System;

namespace Ex4
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
            _company.AddEmployee("Pateta Alegre", 123123123, 5000.00,0.06,600, 0);
            _company.AddEmployee("Bob", 696969696, 9000.00,0.1,2000, 0);
            _company.AddEmployee("Paulo Silva", 123123123,1000);
            _company.AddEmployee("Beatriz Carvalho", 234234234, 10,20,180);
            _company.AddEmployee("Ricardo Gonçalves", 456456456, 10000.00,0.06);
            _company.AddEmployee("Diogo Brás", 567567567, 5000.00,0.04,600, 100);
            Console.WriteLine(_company.ShowWages());
        }
    }
}