using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualRevenue { get; set; }

        public TaxPayer(string name, double anualRevenue)
        {
            Name = name;
            AnualRevenue = anualRevenue;
        }

        public abstract double imposto();
    }
}
