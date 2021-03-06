﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto OutroImposto) : base(OutroImposto) { }
        public ICMS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
