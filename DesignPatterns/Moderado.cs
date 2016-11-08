using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Moderado : Investimento
    {
        public double Calculo(double valor)
        {
            double resultado = 0;
            double saldo = 0;
            int aleatorio = new Random().Next(101);

            if (aleatorio > 50)
            {
                saldo = valor * 0.025;  //-- 2,5 %

            } else
            {
                saldo = valor * 0.007;  //-- 0,7 %
            }

            saldo = saldo * 0.75;   //-- Imposto de 25%

            resultado = valor + saldo;

            return resultado;
        }
    }
}
