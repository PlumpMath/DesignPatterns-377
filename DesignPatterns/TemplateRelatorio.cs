using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TemplateRelatorio 
    {
        public string GerarRelatorio(List<Conta> contas)
        {
            string resultado = "";

            resultado += this.Cabecalho() + "\n";
            resultado += this.Corpo(contas) + "\n";
            resultado += this.Rodape(); 

            return resultado;
           
        }

        protected abstract string Cabecalho();
        protected abstract string Corpo(List<Conta> contas);
        protected abstract string Rodape();
    }

}
