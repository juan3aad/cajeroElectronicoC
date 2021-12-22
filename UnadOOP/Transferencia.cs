using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    class Transferencia : Principal
    {
        override
	    public void transacciones() {
		    Console.WriteLine("Valor para realizar la transferencia");
		transferencia();
		if(trasferen<=getSaldo()) {
			transaccion=getSaldo();
			setSaldo(transaccion-trasferen);
			Console.WriteLine("---------------------------");
			
			Console.WriteLine("Valor transferencia:{0} ", trasferen);
			Console.WriteLine("Numero de cuenta:{0} ", cta);
			Console.WriteLine("Tu saldo actual es: "+getSaldo());
			Console.WriteLine("---------------------------");
		}else {
			Console.WriteLine("----------------------------");
			Console.WriteLine("Saldo insuficiente. ");
            Console.WriteLine("----------------------------");
		}
			
	}


    }
}
