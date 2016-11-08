using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public double Calculo(double valor, Investimento perfilInvestimento)
        {
            double resultado = perfilInvestimento.Calculo(valor);
           
            return resultado;
        }
    }
}
