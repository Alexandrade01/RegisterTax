using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterTax.Entities;
using System.Globalization;

namespace RegisterTax
{
    class Program
    {


        static void Main(string[] args)
        {
            List<TaxPayer> ListofPayers = new List<TaxPayer>();
            double cont = 0;

            Console.Write("Enter the number of tax payers:");
            int numberpayers = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= numberpayers; i++)
            {
                char iresp;
                do
                {
                    Console.WriteLine($"Tax payer #{i} data:");
                    Console.Write("Individual or company (i/c)?");
                    iresp = Convert.ToChar(Console.ReadLine());
                    if(iresp== 'i' || iresp == 'c') { break; }
                }
                while (true);
               
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Anual Income :");
                double.TryParse(Console.ReadLine(), out double income);
                if (iresp == 'i')
                {
                    Console.Write("Health expenditures :");
                    double He = Convert.ToDouble(Console.ReadLine());
                    ListofPayers.Add(new Individual(income, name, He));
                }
                else if (iresp == 'c')
                {
                    Console.Write("Number of employees :");
                    int Ne = Convert.ToInt32(Console.ReadLine());
                    ListofPayers.Add(new Company(income,name,Ne));
                }
            }
            Console.WriteLine( "\n  Taxes Paid :");

            foreach(var taxes in ListofPayers)
            {

                if(taxes is Individual)
                {
                    cont += (taxes as Individual).Tax();
                    Console.WriteLine($"{taxes.Name}: {taxes.Tax().ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
                }
                else
                {
                    cont += (taxes as Company).Tax();
                    Console.WriteLine($"{taxes.Name}: {taxes.Tax().ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
                }
                   

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total Taxes "+cont.ToString("C2",CultureInfo.CreateSpecificCulture("en-US")));
            


        }
    }
}
