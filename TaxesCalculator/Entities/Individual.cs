using System;
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
            if(AnualIncome <= 20000.00)
            {
                if(HealthExpenditures > 0)
                {
                    return (AnualIncome * (15/100)) - (HealthExpenditures * (50 / 100));
                }
                else
                {
                    return AnualIncome * (15 / 100);
                }
            }
            else
            {
                if(HealthExpenditures > 0)
                {
                    return (AnualIncome * (25 / 100)) - (HealthExpenditures * (50 / 100));
                }
                else
                {
                    return AnualIncome * (25 / 100);
                }
            }
        }
    }
}
