using System.Runtime.InteropServices;

namespace Ex4
{
    public abstract class Employee
    {
        protected readonly string Name;
        protected readonly int Nif;

        protected Employee(string name, int nif)
        {
            Name = name;
            Nif = nif;
        }

        protected abstract double FinalWage();


    }
}