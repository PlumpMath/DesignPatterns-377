using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace DesignPatterns
{
    public class CRM
    {
        //-- Conteudo básico do XML
        string caminho;
        int total;
        bool status;
        string mensagem;
        int api_limite;
        int api_consultas;

        //-- Verificar qual tipo do texto
        bool lTotal = false;
        bool lStatus = false;
        bool lMensagem = false;
        bool lApi_limite = false;
        bool lApi_consultas = false;
        bool lTipo = false;
        bool lNumero = false;
        bool lNome = false;
        bool lUF = false;
        bool lProfissao = false;
        bool lSituacao = false;

        //-- Itens do XML
        List<ItemCRM> listaCRM;

        public CRM(string caminhoXML)
        {
            this.caminho = caminhoXML;

            listaCRM = new List<ItemCRM>();

            if (LerXML())
            {
                MessageBox.Show("XML lido com sucesso.");
            }else
            {
                MessageBox.Show("Erro ao ler o XML.");
            }

        }

        public string SituacaoCRM(string UF)
        {
            foreach (ItemCRM medico in listaCRM)
            {
                if (UF.Equals(medico.uf))
                {
                    return medico.situacao;

                }
            }

            return "Não encontrado";
        }

        public bool LerXML()
        {

            //-- Verificar se o arquivo existe
            if (!File.Exists(this.caminho))
            {
                return false;
            }

            //-- Criar objeto para leitura
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(this.caminho, settings);

            reader.MoveToContent();

            //-- Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    //-- Verificar cabeçalho
                    case XmlNodeType.Element:

                        //-- Limpar flags
                        this.lTotal = false;
                        this.lStatus = false;
                        this.lMensagem = false;
                        this.lApi_limite = false;
                        this.lApi_consultas = false;
                        this.lTipo = false;
                        this.lNumero = false;
                        this.lNome = false;
                        this.lUF = false;
                        this.lProfissao = false;
                        this.lSituacao = false;

                        if (reader.Name == "total")
                        {
                            this.lTotal = true;
                        }else if (reader.Name == "status")
                        {
                            this.lStatus = true;
                        }else if (reader.Name == "mensagem")
                        {
                            this.lMensagem = true;
                        }else if (reader.Name == "api_limite")
                        {
                            this.lApi_limite = true;
                        }else if (reader.Name == "api_consultas")
                        {
                            this.lApi_consultas = true;
                        }else if (reader.Name == "item")
                        {
                            this.listaCRM.Add(new ItemCRM());
                        }else if (reader.Name == "tipo")
                        {
                            this.lTipo = true;
                        }else if (reader.Name == "numero")
                        {
                            this.lNumero = true;
                        }else if (reader.Name == "nome")
                        {
                            this.lNome = true;
                        }else if (reader.Name == "uf")
                        {
                            this.lUF = true;
                        }else if (reader.Name == "profissao")
                        {
                            this.lProfissao = true;
                        }else if (reader.Name == "situacao")
                        {
                            this.lSituacao = true;
                        }
                        
                        break;

                    //-- Salvar conteúdo de acordo com o cabeçalho
                    case XmlNodeType.Text:
            
                        if (this.lTotal)
                        {
                            this.total = Convert.ToInt16(reader.Value);
                        }else if (this.lStatus)
                        {
                            this.status = Convert.ToBoolean(reader.Value);
                        }else if (this.lMensagem)
                        {
                            this.mensagem = reader.Value;
                        }else if (this.lApi_limite)
                        {
                            this.api_limite = Convert.ToInt16(reader.Value);
                        }else if (this.lApi_consultas)
                        {
                            this.api_consultas = Convert.ToInt16(reader.Value);
                        }else if (this.lApi_consultas)
                        {
                            this.api_consultas = Convert.ToInt16(reader.Value);
                        }else if (this.lTipo)
                        {
                            this.listaCRM[this.listaCRM.Count - 1].tipo = reader.Value;
                        }else if (this.lNumero)
                        {
                            this.listaCRM[this.listaCRM.Count - 1].numero = Convert.ToInt16(reader.Value);
                        }else if (this.lNome)
                        {
                            this.listaCRM[this.listaCRM.Count - 1].nome = reader.Value;
                        }else if (this.lUF)
                        {
                            this.listaCRM[this.listaCRM.Count - 1].uf = reader.Value;
                        }else if (this.lProfissao)
                        {
                            this.listaCRM[this.listaCRM.Count - 1].profissao = reader.Value;
                        }else if (this.lSituacao)
                        {
                            this.listaCRM[this.listaCRM.Count - 1].situacao = reader.Value;
                        }

                        break;
                }
            }

            return true;
        }
    }

    public class ItemCRM
    {
        public string tipo = "";
        public int numero = 0;
        public string nome = "";
        public string uf = "";
        public string profissao = "";
        public string situacao = "";
    }
}
