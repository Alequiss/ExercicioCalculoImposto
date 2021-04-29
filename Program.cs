using System;
using System.Collections.Generic;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> TaxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int nTaxPayers = int.Parse(Console.ReadLine());

            for (int c = 1; c <= nTaxPayers; c++)
            {
                Console.WriteLine($"Tax payer #{c} data: ");
                Console.Write("Individual or company (i/c)? ");
                char individualOrCompany = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (individualOrCompany == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    PessoaFisica person1 = new PessoaFisica(name, anualIncome, healthExpenditures);
                    TaxPayers.Add(person1);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    PessoaJuridica person1 = new PessoaJuridica(name, anualIncome, numberEmployees);
                    TaxPayers.Add(person1);
                }           
            }
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer t in TaxPayers)
            {
                Console.WriteLine($"{t.Name}: $ {t.imposto()}");
            }
        }
    }
}
