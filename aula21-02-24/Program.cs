using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula21_02_24_eloisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente("Eloisa", 5000);
            conta1.Depositar(2000);
            conta1.Depositar(1420);
            conta1.Sacar(350);
        }
    }
}
