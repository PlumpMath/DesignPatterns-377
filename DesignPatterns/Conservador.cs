using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conservador : Investimento
    {
        public double Calculo(double valor)
        {
            double resultado = 0;
            double saldo = 0;

            saldo = valor * 0.008;  //-- 0,8 %

            saldo = saldo * 0.75;   //-- Imposto de 25%

            resultado = valor + saldo;

            return resultado;
        }
    }
}
