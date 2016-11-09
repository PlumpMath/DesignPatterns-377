using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            bool temLapis = false;
            bool temCaneta = false;

            foreach (var itemOrcamento in orcamento.Itens)
            {
                if (itemOrcamento.Nome.Equals("LAPIS"))
                {
                    temLapis = true;

                }else if (itemOrcamento.Nome.Equals("CANETA"))
                {
                    temCaneta = true;
                }

                if (temCaneta && temLapis)
                {
                    break;
                }
            }

            if (temCaneta && temLapis)
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}

