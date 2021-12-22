using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    class Consulta : Principal
    {
        override
	    public void transacciones() {
		Console.WriteLine("--------------------------------");
		Console.WriteLine("Tu saldo actual es: "+getSaldo());
        Console.WriteLine("--------------------------------");
		
	    }


    }
}
