using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Moderado : Investimento
    {
        public double Calculo(Conta conta)
        {
            double resultado = 0;
            double valor = conta.Saldo;

            int aleatorio = new Random().Next(101);

            if (aleatorio > 50)
            {
                resultado = valor * 0.025;  //-- 2,5 %

            } else
            {
                resultado = valor * 0.007;  //-- 0,7 %
            }

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
