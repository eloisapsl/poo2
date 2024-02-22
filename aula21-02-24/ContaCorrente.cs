using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula21_02_24_eloisa
{
    internal class ContaCorrente
    {
        public string proprietario { get; set; }
        public double saldo { get; private set; }
        public string log { get; private set; }

        public ContaCorrente(string proprietario, double saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
            this.log = "\nExtrato de: " + this.proprietario + "\n";
        }

        public Boolean Sacar(double valor_saque) 
        {
            if(saldo >= valor_saque)
            {
                saldo = saldo - valor_saque;
                Console.WriteLine("Saque realizado.");
                this.log += "\Saque de: " + valor_saque.ToString();
                return true; 
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                this.log += "\nTentativa de saque, saldo insuficiente.";
                return false;
            }
        }

        public Boolean Depositar(double valor_deposito) 
        { 
            saldo = saldo + valor_deposito;
            Console.WriteLine("saldo atualizado.");
            this.log += "\Depósito de: " + valor_deposito.ToString();
            return true; 
        }
    }
}
