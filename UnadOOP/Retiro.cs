using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    class Retiro : Principal
    {
        override
        public void transacciones()
        {
            Console.WriteLine("Cuanto deseas retirar");
            retiro();
            if (reti <= getSaldo())
            {
                transaccion = getSaldo();
                setSaldo((transaccion - reti));
                Console.WriteLine("---------------------------");
                Console.WriteLine("Retiraste:{0} ", reti);
                Console.WriteLine("Tu saldo actual es: " + getSaldo());
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Saldo insuficiente. ");
                Console.WriteLine("----------------------------");
            }
        }
    }
}
