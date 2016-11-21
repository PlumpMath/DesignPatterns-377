using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface EstadoOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);

    }

    //-- Em aprovação
    public class EmAprovacao : EstadoOrcamento
    {
        bool DescontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado)
            {
                throw new Exception("Desconto em aprovação já efetuado.");
            }
            else
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                DescontoAplicado = true;
            }
            
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não é permitido finalizar sem passar pela aprovação antes.");
        }
    }
    //-- Aprovado
    public class Aprovado : EstadoOrcamento
    {

        bool DescontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado)
            {
                throw new Exception("Desconto para aprovados já efetuado.");
            }
            else
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                DescontoAplicado = true;
            }

        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }

    //-- Reprovado
    public class Reprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não permite desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi reprovado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }

    //-- Finalizado
    public class Finalizado: EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não permite desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado, não permite aprovar.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado, não permite reprovar."); 
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado."); 
        }
    }
}
