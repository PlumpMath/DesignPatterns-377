using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Imposto
    {
        private readonly Imposto OutroImposto;

        //-- Construtor com novo imposto
        public Imposto(Imposto OutroImposto)
        {
            this.OutroImposto = OutroImposto;
        }

        //-- Construtor default
        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            //-- Tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null)
            {
                return 0;
            }else
            {
                return OutroImposto.Calcula(orcamento);
            }            
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
