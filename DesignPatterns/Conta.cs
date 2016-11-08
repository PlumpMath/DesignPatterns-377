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
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }

}
