using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public double Calculo(Conta conta, Investimento perfilInvestimento)
        {
            double valorInvestimento = perfilInvestimento.Calculo(conta);

            MessageBox.Show("Investimento: " + valorInvestimento);

            valorInvestimento -= perfilInvestimento.CalculaImposto(valorInvestimento);

            MessageBox.Show("Investimento sem imposto: " + valorInvestimento);

            conta.Deposita(valorInvestimento);
           
            return conta.Saldo;
        }
    }
}
