using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
//Contas com saldo menor que 100 reais ou
//Contas com saldo maior do que 500 mil reais, ou
//Contas com data de abertura no mês corrente Todas essas são geralmente selecionadas para uma análise mais detalhada.
    public abstract class Filtro
    {
        public abstract IList<Conta> Filtra(IList<Conta> contas);

        private readonly Filtro OutroFiltro;

        //-- Construtor com novo imposto
        public Filtro(Filtro OutroFiltro)
        {
            this.OutroFiltro = OutroFiltro;
        }

        //-- Construtor default
        public Filtro()
        {
            this.OutroFiltro = null;
        }

        public IList<Conta> AplicaFiltros(IList<Conta> contas)
        {
            IList<Conta> resultado = new List<Conta>();
            resultado = Filtra(contas);

            if (this.OutroFiltro != null)
            {
                resultado = OutroFiltro.Filtra(resultado);
            }

            return resultado;
        }
    }

    public class SaldoBaixo : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> resultado = new List<Conta>();

            foreach (Conta item in contas)
            {
                if(item.Saldo < 100)
                {
                    resultado.Add(item);
                }
            }

            return resultado;
        }
    }
    public class SaldoAlto : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> resultado = new List<Conta>();

            foreach (Conta item in contas)
            {
                if (item.Saldo > 500000)
                {
                    resultado.Add(item);
                }
            }

            return resultado;
        }
    }
    public class MesAtual : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> resultado = new List<Conta>();

            foreach (Conta item in contas)
            {

                if (item.Data.Month.Equals( DateTime.Now.Month ) )
                {
                    resultado.Add(item);
                }
            }

            return resultado;
        }
    }
}
