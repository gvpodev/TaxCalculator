using System;
using TaxesCalculator.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 1; i <= taxPayers; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data: ");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i' || type == 'I')
                {
                    Console.Write("Heath Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    people.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (type == 'c' || type == 'C')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    people.Add(new Company(name, anualIncome, employees));
                }
                else
                {
                    Console.WriteLine("Invalid type.");
                }
            }

            Console.WriteLine();

            double totalTax = 0;

            foreach (Person p in people)
            {
                double tax = p.TaxCalculator();
                Console.WriteLine(p.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTax += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}