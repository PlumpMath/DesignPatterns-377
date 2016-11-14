using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns
{
    public class WebserviceCRM
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Rss));
        FileStream fileStream = new FileStream(@"C:\CSharp\CRM_Retorno.xml", FileMode.Open);
        Rss result;

        [XmlRoot("rss")]
        public class Rss
        {
            [XmlElement("channel")]
            public Channel channel { get; set; }
        }

        public class Channel
        {
            [XmlElement("url")]
            public string Url { get; set; }

            [XmlElement("total")]
            public int Total { get; set; }

            [XmlElement("mensagem")]
            public string Mensagem { get; set; }

            [XmlElement("api_limite")]
            public int ApiLimite { get; set; }

            [XmlElement("api_consultas")]
            public int ApiConsultas { get; set; }

            [XmlElement("item")]
            public List<Item> Items { get; set; }
        }

        public class Item
        {
            [XmlElement("tipo")]
            public string Tipo { get; set; }

            [XmlElement("numero")]
            public int Numero { get; set; }

            [XmlElement("nome")]
            public string Nome { get; set; }

            [XmlElement("uf")]
            public string Uf { get; set; }

            [XmlElement("profissao")]
            public string Profissao { get; set; }

            [XmlElement("situacao")]
            public string Situacao { get; set; }
        }
        public bool LerRetorno()
        {
            bool resultado = false;
            string mensagem = "";
            string msgUF = "";

            this.result = (Rss)serializer.Deserialize(fileStream);

            mensagem += String.Format("Consultas efetuadas: {0} de {1}", this.result.channel.ApiConsultas, this.result.channel.ApiLimite)+"\n";

            foreach (Item CrmUf in this.result.channel.Items)
            {
                if ( CrmUf.Uf == "SP")
                {
                    msgUF = String.Format("{0}: {1} da UF: {2} \nNome: {3}\nSituação: {4}\n", CrmUf.Tipo, CrmUf.Numero, CrmUf.Uf, CrmUf.Nome, CrmUf.Situacao);
                    if (!String.IsNullOrEmpty(CrmUf.Profissao))
                    {
                        msgUF += "Especialidade: "+ CrmUf.Profissao;
                    }
                }

                mensagem += String.Format("Status do CRM: {0} na UF: {1} é: {2} ", CrmUf.Numero, CrmUf.Uf, CrmUf.Situacao) +"\n";
            }

            MessageBox.Show(mensagem);
            MessageBox.Show(msgUF);

            return resultado;
        }
    }
}
