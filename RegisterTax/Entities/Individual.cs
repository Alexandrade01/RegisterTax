using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTax.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(double anualnCome, string name,double healthExpenditures) : base(anualnCome, name)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double final = 0;
            if (AnualnCome < 20000) { final = AnualnCome * 0.15; }
            else
            {
                final = AnualnCome * 0.25;
                final -= HealthExpenditures * 0.5;
            }
            return final;
        }
    }
}
       


           

