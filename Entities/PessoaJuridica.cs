using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    class PessoaJuridica : TaxPayer
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string name, double anualRevenue, int nFuncionarios) 
            : base(name, anualRevenue)
        {
            NumeroFuncionarios = nFuncionarios;
        }

        public override double imposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return AnualRevenue * 14 / 100;
            }
            else
            {
                return AnualRevenue * 16 / 100;
            }
        }
    }
}
