using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public class RelatorioDetalhado : TemplateRelatorio
    {

        protected override string Cabecalho()
        {
            string resultado = "";
            //-- Informam o nome do banco, endereço, telefone
            resultado += String.Format("Nome do banco: {0}\nEndereço: {1}\nTelefone: {2}", "Banco do Samir", "Rua Capitão Neném Figueiredo, 89", "(22)3861-8500");
            return resultado;
        }
        protected override string Corpo(List<Conta> contas)
        {
            string resultado = "";

            foreach (Conta conta in contas)
            {
                //-- exibe titular, agência, número da conta, e saldo.
                resultado += String.Format("Titular: {0} Ag.: {1} Conta: {2} Saldo: {3}",conta.Titular, conta.Agencia, conta.NumeroConta, conta.Saldo);
                resultado += "\n";//-- Quebrar a linha
            }

            return resultado;
        }
        protected override string Rodape()
        {
            string resultado = "";
            //-- Informam e-mail, e a data atual.
            resultado += String.Format("E-mail: {0}\nData: {1}", "rcasistemas@rcasistemas.com.br", "Rua Capitão Neném Figueiredo, 89", DateTime.Now);
            return resultado;
        }
    }
}
