using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    class Deposito: Principal
    {
        override
	    public void transacciones() {
		Console.WriteLine("Cuanto deseas depositar:");
		deposito();
		transaccion=getSaldo();
        setSaldo((transaccion + deposi));
		
		punto=getPto();
		setPto(punto+1);
		
		Console.WriteLine("---------------------------");
        Console.WriteLine("Despositaste:{0} ", deposi);
		Console.WriteLine("Tu saldo es: "+getSaldo());
        Console.WriteLine("---------------------------");
	}

    }
}
