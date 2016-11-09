using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta Proxima { get; set; }
    }

    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }

    }

    public class RespostaEmXml : Resposta
    {
        public Resposta Proxima { get; set; }
        public RespostaEmXml(Resposta outraResposta)
        {
            this.Proxima = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }
    }

    public class RespostaEmCsv : Resposta
    {
        public Resposta Proxima { get; set; }
        public RespostaEmCsv(Resposta outraResposta)
        {
            this.Proxima = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }
    }

    public class RespostaEmPorcento : Resposta
    {
        public Resposta Proxima { get; set; }
        public RespostaEmPorcento(Resposta outraResposta)
        {
            this.Proxima = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }
    }
}
