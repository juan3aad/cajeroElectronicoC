using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    class Punto : Principal
    {

        override
	    public void transacciones() {
		
		Console.WriteLine("---------------------------");
		Console.WriteLine("Total Puntos: "+getPto());
        Console.WriteLine("---------------------------");
	    }
    }
}
