using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace DesignPatterns
{
    public partial class FormPrincipal : Form
    {
        public CalculadorDeImposto calculadora = new CalculadorDeImposto();
        public RealizadorDeInvestimentos calculadorInvestimento = new RealizadorDeInvestimentos();
        public CalculadorDeDescontos calculadorDesconto = new CalculadorDeDescontos(); 
        public Conta contaTeste = new Conta();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonICMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imposto ICMS: " + calculadora.Calcula( new Orcamento(Convert.ToDouble(textValor.Text)),
                                                                    new ICMS() ) );
        }

        private void buttonISS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imposto ISS: " + calculadora.Calcula(  new Orcamento(Convert.ToDouble(textValor.Text)),
                                                                    new ISS() ) );
        }

        private void buttonICCC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imposto ICCC: " + calculadora.Calcula( new Orcamento(Convert.ToDouble(textValor.Text)),    
                                                                    new ICCC() ) );
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            FormPrincipal.ActiveForm.Close();
        }

        private void buttonConservador_Click(object sender, EventArgs e)
        {

            contaTeste.Deposita(contaTeste.Saldo * -1);
            contaTeste.Deposita(Convert.ToDouble(textValor.Text));

            MessageBox.Show("Após investimento conservador: " + 
                            calculadorInvestimento.Calculo(contaTeste,
                            new Conservador()));         
        }

        private void buttonModerado_Click(object sender, EventArgs e)
        {

            contaTeste.Deposita(contaTeste.Saldo * -1);
            contaTeste.Deposita(Convert.ToDouble(textValor.Text));

            MessageBox.Show("Após investimento moderado: " +
                            calculadorInvestimento.Calculo(contaTeste,
                            new Moderado()));
        }

        private void buttonArrojado_Click(object sender, EventArgs e)
        {

            contaTeste.Deposita(contaTeste.Saldo * -1);
            contaTeste.Deposita(Convert.ToDouble(textValor.Text));

            MessageBox.Show("Após investimento arrojado: " +
                            calculadorInvestimento.Calculo(contaTeste,
                            new Arrojado()));
        }

        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            Orcamento testeOrcamento = new Orcamento(Convert.ToDouble(textValor.Text));
            double valorOrcamento = Convert.ToDouble(textValor.Text);
            int qtdItens = Convert.ToInt16(textQuantidade.Text);
            double valorItem = valorOrcamento/qtdItens;

            for ( int i = 0; i < qtdItens; i++)
            {
                testeOrcamento.AdicionaItem(new Item("Teste: "+i, valorItem));
            }

            MessageBox.Show("Desconto : " + calculadorDesconto.Calcula(testeOrcamento));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CRM objCRM = new CRM(@"C:\CRM_Retorno.xml");
            MessageBox.Show(objCRM.SituacaoCRM("RJ"));

        }
    }
}
