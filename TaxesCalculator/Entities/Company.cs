using System.Globalization;
using System.Text;
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
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
