using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //-- IMA - Imposto Muito Alto
    public class IMA: Imposto
    {
        public IMA(Imposto OutroImposto) : base(OutroImposto) { }
        public IMA() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
