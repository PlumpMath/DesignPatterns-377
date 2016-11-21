using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conta
    {
        public StatusConta Status;

        public Conta()
        {
            Status = new ContaPositiva();
        }

        public double Saldo { get; set; }
        public string Titular { get; set; }

        public int Agencia { get; set; }
        public int NumeroConta { get; set; }

        public DateTime Data { get; set; }

        public void Deposita(double valor)
        {
            //this.Saldo += valor;
            Status.Deposita(this, valor);
            this.AtualizaStatus();
        }
        public void Saca(double valor)
        {
            //this.Saldo -= valor;
            Status.Saca(this, valor);
            this.AtualizaStatus();
        }

        public void AtualizaStatus()
        {
            if (this.Saldo < 0)
            {
                this.Status = new ContaPositiva();
            }
            else
            {
                this.Status = new ContaNegativa();
            }
        }
    }

    public interface StatusConta
    {
        void Deposita(Conta conta, double valor);
        void Saca(Conta conta, double valor);
    }

    //Uma conta que está com saldo positivo, aceita saques, e o banco deposita 98% do valor do depósito.
    public class ContaPositiva : StatusConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor*0.98;
        }
        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;

        }

    }
    //Uma conta que está negativo, por exemplo, não aceita saques, e depositam apenas 95% do valor total de um depósito efetuado.
    public class ContaNegativa : StatusConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor*0.95;
        }
        public void Saca(Conta conta, double valor)
        {
            //conta.Saldo -= valor;
            throw new Exception("Conta com saldo negativo, não permite saque.");
        }
    }
}
