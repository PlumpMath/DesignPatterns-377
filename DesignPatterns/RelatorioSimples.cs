using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override string Cabecalho()
        {
            string resultado = "";
            //-- apenas com o nome do banco,
            resultado += String.Format("Nome do banco: {0}","Banco do Samir");
            return resultado;
        }
        protected override string Corpo(List<Conta> contas)
        {
            string resultado = "";

            foreach (Conta conta in contas)
            {
                //-- imprime titular e saldo da conta
                resultado += String.Format("Titular: {0} Saldo: {1}", conta.Titular, conta.Saldo);
                resultado += "\n";//-- Quebrar a linha
            }

            return resultado;
        }
        protected override string Rodape()
        {
            string resultado = "";
            //-- apenas  telefone,
            resultado += String.Format("Telefone: {0}", "(22)3861-8500");

            return resultado;
        }
    }
}
