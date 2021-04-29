using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    class PessoaFisica : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica(string name, double anualRevenue, double gastosSaude)
            : base(name, anualRevenue)
        {
            HealthExpenditures = gastosSaude;
        }

        public override double imposto()
        {
            if (AnualRevenue < 20000)
            {
                return AnualRevenue * 15 / 100 - (HealthExpenditures / 2);
            }
            else
            {
                return AnualRevenue * 25 / 100 - (HealthExpenditures / 2);
            }
        }
    }
}
