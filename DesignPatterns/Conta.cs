using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public int Agencia { get; set; }
        public int NumeroConta { get; set; }

        public DateTime Data { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }

}
