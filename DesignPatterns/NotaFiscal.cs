using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscal
    {
        private String RazaoSocial { get; private set; }
        private String Cnpj { get; private set; }
        private DateTime DataDeEmissao { get; private set; }
        private double ValorBruto { get; private set; }
        private double Impostos { get; private set; }
        public IList<ItemDaNota> Itens { get; private set; }
        public String Observacoes { get; private set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<ItemDaNota> itens,
                      String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }

    public class ItemDaNota
    {
        public string Descricao;
        public double Valor;

        public ItemDaNota( String Descricao, Double Valor)
        {
            this.Descricao = Descricao;
            this.Valor = Valor;
        }

    }

    class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public String Observacoes { get; private set; }

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this; //-- retornar o próprio builder, para que continue utilizando
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this; //-- retornar o próprio builder, para que continue utilizando
        }

        public NotaFiscalBuilder AdicionaItem(String descricao, Double valor)
        {
            //-- Criar o item
            ItemDaNota item = new ItemDaNota(descricao, valor);
            
            //-- Adicionar ao construtor
            this.ComItem(item);

            return this; //-- retornar o próprio builder, para que continue utilizando
        }
        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this; //-- retornar o próprio builder, para que continue utilizando
        }
        public NotaFiscalBuilder ComData(DateTime data)
        {
            this.Data = data;
            return this; //-- retornar o próprio builder, para que continue utilizando
        }
        public NotaFiscalBuilder ComObservacao(String observacao)
        {
            //-- Se estiver vazio
            if ( string.IsNullOrEmpty(this.Observacoes))
            {
                //-- Inicializa variável
                this.Observacoes = observacao;
            }
            else //-- Se não estiver vazio
            {
                //-- Quebra linha e concatena a próxima observação
                this.Observacoes += "\n" + observacao;
            }
            
            return this; //-- retornar o próprio builder, para que continue utilizando
        }
    }
}
