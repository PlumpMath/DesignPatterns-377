using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto OutroImposto) : base(OutroImposto) { }
        public IHIT() : base() { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return TemItemRepetido(orcamento);
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13 )+100;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        private bool TemItemRepetido(Orcamento orcamento)
        {
            List<String> encontrados = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (encontrados.Contains(item.Nome))
                {
                    return true;
                }else
                {
                    encontrados.Add(item.Nome);
                }
            }

            return false;
        }
    }

}
