using System.Globalization;
using System.Text;
namespace TaxesCalculator.Entities
{
    public class Individual : Person
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public Individual()
        {
        }

        public override double TaxCalculator()
        {
            if(AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name + TaxCalculator().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
