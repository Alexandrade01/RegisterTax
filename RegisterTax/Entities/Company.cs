using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegisterTax.Entities
{
    class Company:TaxPayer
    {
       

        public int NumberOfEmployees { get; set; }
        public Company(double anualnCome, string name,int numberOfEmployees) : base(anualnCome, name)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double final = 0;
            if (NumberOfEmployees > 10) { final += AnualnCome * 0.14; }
            else { final += AnualnCome * 0.16; }
            return final;
        }
       
    }
}

