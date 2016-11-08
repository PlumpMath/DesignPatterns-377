using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Arrojado : Investimento
    {
        public double Calculo(Conta conta)
        {
            double resultado = 0;
            double valor = conta.Saldo;

            int aleatorio = new Random().Next(101);

            if (aleatorio > 50)
            {
                resultado = valor * 0.006;  //-- 0,6 %
            }
            else if (aleatorio > 30)
            {
                resultado = valor * 0.03;   //-- 3 %
            }
            else
            {
                resultado = valor * 0.05;   //-- 5 %
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
