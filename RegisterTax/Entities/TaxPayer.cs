using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTax.Entities
{
    abstract class TaxPayer
    {
        double anualnCome;
        public string Name { get; set; }
        public double AnualnCome { get => anualnCome; }
        protected TaxPayer(double anualnCome, string name)
        {
            this.anualnCome = anualnCome;
            Name = name;
        }

        public abstract double Tax();

      

        
    }
}
