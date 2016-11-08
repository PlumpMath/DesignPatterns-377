using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImposto
    {
        public double Calcula(Orcamento orcamento, Imposto estrategiaDeImposto)
        {
            double resultado = estrategiaDeImposto.Calcula(orcamento);
            //Console.WriteLine(resultado);
            return resultado;
        }
    }
}
