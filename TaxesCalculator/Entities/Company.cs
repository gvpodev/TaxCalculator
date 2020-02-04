using System;
namespace TaxesCalculator.Entities
{
    public class Company : Person
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public Company()
        {
        }

        public override double TaxCalculator()
        {
            if(Employees > 10)
            {
                return AnualIncome * (14 / 100);
            }
            else
            {
                return AnualIncome * (16 / 100);
            }
        }
    }
}
