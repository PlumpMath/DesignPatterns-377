using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conservador : Investimento
    {
        public double Calculo(Conta conta)
        {
            double resultado = 0;
            double valor = conta.Saldo;

            resultado = valor * 0.008;  //-- 0,8 %

            return resultado;
        }
        public double CalculaImposto(double valor)
        {
            double valorImposto = 0;

            valorImposto = valor * 0.25;   //-- Imposto de 25%

            return valorImposto;
        }
    }
}
