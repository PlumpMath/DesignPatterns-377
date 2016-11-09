using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {

        public IList<Desconto> ListaDescontos { get; private set; }

        public double Calcula(Orcamento orcamento)
        {

            ListaDescontos = new List<Desconto>();

            //-- Adicionar os tipos de descontos existentes a lista para serem encadeados
            this.ListaDescontos.Add(new DescontoPorCincoItens() );
            this.ListaDescontos.Add(new DescontoPorMaisDeQuinhentosReais() );

            this.ListaDescontos.Add(new SemDesconto() ); //-- Importante! Deve ser o último!

            //-- Definir a cadeia de execução dos descontos.
            for ( int contador = 0; contador < ListaDescontos.Count; contador++)
            {
                //-- Verificar se não é último desconto ( Sem desconto )
                if ( contador + 1 < ListaDescontos.Count) 
                {
                    //-- Definir que o próximo item da lista é o desconto a ser executado
                    ListaDescontos[contador].Proximo = ListaDescontos[contador + 1];
                }
            }

            //-- Executar o primeiro desconto e os demais serão executados em cadeia
            return ListaDescontos[0].Desconta(orcamento);
        }
    }
}
