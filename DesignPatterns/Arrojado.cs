using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Arrojado : Investimento
    {
        public double Calculo(double valor)
        {
            double resultado = 0;
            double saldo = 0;
            int aleatorio = new Random().Next(101);

            if (aleatorio > 50)
            {
                saldo = valor * 0.006;  //-- 0,6 %
            }
            else if (aleatorio > 30)
            {
                saldo = valor * 0.03;   //-- 3 %
            }
            else
            {
                saldo = valor * 0.05;   //-- 5 %
            }

            saldo = saldo * 0.75;   //-- Imposto de 25%

            resultado = valor + saldo;

            return resultado;
        }
    }
}
