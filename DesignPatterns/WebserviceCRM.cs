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
    class WebserviceCRM
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Rss));
using (FileStream fileStream = new FileStream("C:\CRM_Retorno.xml", FileMode.Open)) 
{
    Rss result = (Rss)serializer.Deserialize(fileStream);
}

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

    }
}
