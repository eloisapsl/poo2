using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula21_02_24_eloisa
{
    internal class ContaCorrente
    {
        private string proprietario { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(string proprietario, double saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
        }

        public Boolean Sacar(double valor_saque) 
        {
            if(saldo >= valor_saque)
            {
                saldo = saldo - valor_saque;
                Console.WriteLine("Saque realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            return true; 
        }

        public Boolean Depositar(double valor_deposito) 
        { 
            saldo = saldo + valor_deposito;
            Console.WriteLine("Depósito realizado.");
            return true; 
        }
    }
}
